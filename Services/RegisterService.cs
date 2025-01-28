using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using GeradorDadosAPI.Services.Generators;
using GeradorDadosAPI.Services.Interfaces;

namespace GeradorDadosAPI.Services
{
    public class RegisterService : IRegisterService
    {
        private readonly INameGenerator _nameGenerator;
        private readonly IAgeGenerator _ageGenerator;
        private readonly IGenderGenerator _genderGenerator;
        private readonly IEmailGenerator _emailGenerator;

        public RegisterService(INameGenerator nameGenerator, IAgeGenerator ageGenerator, IGenderGenerator genderGenerator, IEmailGenerator emailGenerator)
        {
            _nameGenerator = nameGenerator;
            _ageGenerator = ageGenerator;
            _genderGenerator = genderGenerator;
            _emailGenerator = emailGenerator;
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
                        person.Mother = _nameGenerator.Generate(EGender.FEMALE,customizableSelections.Region);
                        break;
                }


            }
        }
    }
}
