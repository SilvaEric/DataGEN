using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using GeradorDadosAPI.Services.Generators;
using GeradorDadosAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GeradorDadosAPI.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly INameGenerator _nameGenerator;
        private readonly IAgeGenerator _ageGenerator;
        private readonly IGenderGenerator _genderGenerator;
        private readonly IEmailGenerator _emailGenerator;
        private readonly IGenerateNoParams _passwordGenerator, _bloodTypeGenerator, _heightGenerator, _weightGenerator;
        private readonly IPhoneNumberGenerator _phoneNumberGenerator;

        public RegisterService(
            INameGenerator nameGenerator, 
            IAgeGenerator ageGenerator, 
            IGenderGenerator genderGenerator,
            IEmailGenerator emailGenerator,
            IPhoneNumberGenerator phoneNumberGenerator,
            [FromKeyedServices("password")] IGenerateNoParams passwordGenerator, 
            [FromKeyedServices("bloodtype")] IGenerateNoParams bloodTypeGenerator,
            [FromKeyedServices("height")] IGenerateNoParams heightgenerator, 
            [FromKeyedServices("weight")] IGenerateNoParams weightgenerator )
        {
            _nameGenerator = nameGenerator;
            _ageGenerator = ageGenerator;
            _genderGenerator = genderGenerator;
            _emailGenerator = emailGenerator;
            _passwordGenerator = passwordGenerator;
            _phoneNumberGenerator = phoneNumberGenerator;
            _bloodTypeGenerator = bloodTypeGenerator;
            _heightGenerator = heightgenerator;
            _weightGenerator = weightgenerator;
        }

        public void Register(PersonBase person, CustomizableSelections customizableSelections)
        {
            foreach (var selection in customizableSelections.SelectedDatas)
            {
                switch (selection)
                {
                    case "Gender":
                        if (customizableSelections.Gender.HasValue)
                        {
                            person.Gender = customizableSelections.Gender.Value;
                            break;
                        }
                        person.Gender = _genderGenerator.Generate();
                        break;

                    case "Name":
                        person.Name = _nameGenerator.Generate(person.Gender ?? customizableSelections.Gender ?? _genderGenerator.Generate(), customizableSelections.Region);
                        break;

                    case "Age":
                        if (customizableSelections.Age.HasValue)
                        {
                            person.Age = customizableSelections.Age.Value;
                            break;
                        }

                        person.Age = _ageGenerator.CalculateAge(person.NascDate ?? _ageGenerator.GenerateBirthDate());

                        break;

                    case "NascDate":
                        if (customizableSelections.Age.HasValue)
                        {
                            person.NascDate = _ageGenerator.GetBirthDate(customizableSelections.Age.Value);
                            break;
                        }
                        if (person.Age.HasValue)
                        {
                            person.NascDate = _ageGenerator.GetBirthDate(person.Age.Value);
                            break;
                        }
                        person.NascDate = _ageGenerator.GenerateBirthDate();
                        break;

                    case "Email":
                        person.Email = _emailGenerator.Generate(person.Name ?? _nameGenerator.Generate(person.Gender ?? customizableSelections.Gender ?? _genderGenerator.Generate(), customizableSelections.Region));
                        break;

                    case "Father":
                        person.Father = _nameGenerator.Generate(EGender.MALE, customizableSelections.Region);
                        break;

                    case "Mother":
                        person.Mother = _nameGenerator.Generate(EGender.FEMALE, customizableSelections.Region);
                        break;

                    case "Password":
                        person.Password = Convert.ToString(_passwordGenerator.Generate());
                        break;

                    case "Phone":
                        if (customizableSelections.StatesBR.HasValue)
                        {
                            person.Phone = _phoneNumberGenerator.GenerateBRPhone(customizableSelections.Region, customizableSelections.StatesBR.Value);
                            break;
                        }

                        if (customizableSelections.StatesUS.HasValue)
                        {
                            person.Phone = _phoneNumberGenerator.GenerateUSPhone(customizableSelections.Region, customizableSelections.StatesUS.Value);
                            break;
                        }

                        var random = new Random();

                        if (customizableSelections.Region == ERegion.BR)
                        {
                            var listStatesBR = Enum.GetValues(typeof(EStatesBR)).Cast<EStatesBR>().ToList();
                            person.Phone = _phoneNumberGenerator.GenerateBRPhone(customizableSelections.Region, listStatesBR[random.Next(listStatesBR.Count)]);
                            break;
                        }

                        var listStatesUS = Enum.GetValues(typeof(EStatesUS)).Cast<EStatesUS>().ToList();
                        person.Phone = _phoneNumberGenerator.GenerateUSPhone(customizableSelections.Region, listStatesUS[random.Next(listStatesUS.Count)]);
                        break;

                    case "Weight":
                        person.Weight = Convert.ToDouble(_weightGenerator.Generate());
                        break;

                    case "Height":
                        person.Height = Convert.ToDouble(_heightGenerator.Generate());
                        break;

                    case "BloodType":

                        person.BloodType = Convert.ToString(_bloodTypeGenerator.Generate());
                        break;

                    default:
                        throw new ValidationException($"O dado passado {selection} não exite no contexto atual.");
                }
            }
        }
        public PersonBase GetPersonGenerator(ERegion region)
        {
            switch (region)
            {
                case ERegion.BR:
                    return new BRPersonData(this);

                case ERegion.US:
                    return new USPersonData(this);

                default:
                    throw new NotImplementedException($"A região inserida {region} ainda não está diosponível!");
            }
        }
    }
}
