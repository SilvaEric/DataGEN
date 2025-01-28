using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using GeradorDadosAPI.Services.Interfaces;

namespace GeradorDadosAPI.Services.Generators
{
    public class GenderGenerator : IGenderGenerator
    {
        public EGender Generate()
        {
            Dictionary<int, EGender> genders = new Dictionary<int, EGender>()
            {
                {0, EGender.MALE},
                {1, EGender.FEMALE}
            };

            var random = new Random();

            var genderKey = random.Next(genders.Count);

            return genders[genderKey];
        }
    }
}
