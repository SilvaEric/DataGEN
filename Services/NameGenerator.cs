using GeradorDadosAPI.ContextData;
using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;

namespace GeradorDadosAPI.Services
{
    public class NameGenerator : IGenerator
    {
        public void Generate(CustomizableSelections selections, PersonDataBase person)
        {
            var names = new NamesDataBase().DictionaryRegionsNames[selections.Region];
            var random = new Random();
            var index = random.Next(names.Count);

            person.Name = names[index];
        }
    }
}
