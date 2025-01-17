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
            var secondNames = new SecondNamesDataBase().DictionaryRegionsSecondNames[selections.Region];

            var random = new Random();
            var namesIndex = random.Next(names.Count);
            var secondNamesIndex = random.Next(secondNames.Count);

            person.Name =$"{names[namesIndex]} {secondNames[secondNamesIndex]}";
        }
    }
}
