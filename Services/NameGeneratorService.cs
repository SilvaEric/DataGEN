using GeradorDadosAPI.ContextData;
using GeradorDadosAPI.Enums;

namespace GeradorDadosAPI.Services
{
    public class NameGeneratorService : IGeneratorBase
    {
        public object Generate(ERegion region)
        {
            var names = new NamesData().DictionaryRegionsNames[region];
            var random = new Random();
            var index = random.Next(names.Count);

            return names[index];
        }
    }
}
