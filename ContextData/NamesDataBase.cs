using GeradorDadosAPI.Enums;

namespace GeradorDadosAPI.ContextData
{
    public class NamesDataBase
    {
        public Dictionary<ERegion, List<string>> DictionaryRegionsNames { get; set; } = new Dictionary<ERegion, List<string>>();

        public NamesDataBase()
        {
            DictionaryRegionsNames = new Dictionary<ERegion, List<string>>() 
            {
                { ERegion.BR, new List<string> { "Eric", "Rafael", "Maria", "João" } },
                { ERegion.UK, new List<string> { "John", "Jane", "Michael", "Emily" } },
                { ERegion.US, new List<string> { "Jean", "Marie", "Hans", "Sophie" } },
                { ERegion.AS, new List<string> { "Li Wei", "Akira", "Kim", "Mei" } },
            };
        }
    }
}
