using GeradorDadosAPI.ContextData;
using GeradorDadosAPI.Models;

namespace GeradorDadosAPI.Services
{
    public class EmailGenerator : IGenerator
    {
        public void Generate(CustomizableSelections selections, PersonDataBase person)
        {
            var random = new Random();
            var number = random.Next(1, 2050);
            
            var listMailDomains = new EmailDataBase().EmailsDomains;
            var selectedMailDomain = listMailDomains[random.Next(listMailDomains.Count)];

            (string firstName, string lastName) = GetNameParts(person, selections, random);

            person.Email = $"{firstName}{lastName}{number}{selectedMailDomain}";
        }

        private (string FirstName, string LastName) GetNameParts(PersonDataBase person, CustomizableSelections selections, Random random)
        {
            if (string.IsNullOrWhiteSpace(person.Name))
            {
                new NameGenerator().Generate(selections, person);
            }
            
            var parts = person.Name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            return (parts[0], parts[1]);
        }
    }
}
