using GeradorDadosAPI.Models;

namespace GeradorDadosAPI.Services
{
    public class GenderGenerator : IGenerator
    {
        public void Generate(CustomizableSelections selections, PersonDataBase person)
        {
            Dictionary<int, string> genders = new Dictionary<int, string>()
            {
                {0, "Female"},
                {1, "Male" }
            };

            var random = new Random();

            var genderKey = random.Next(genders.Count);

            person.Gender = genders[genderKey];
        }
    }
}
