using GeradorDadosAPI.Enums;
using Microsoft.Extensions.Hosting;

namespace GeradorDadosAPI.ContextData
{
    public class SecondNamesDataBase
    {
        public Dictionary<ERegion, List<string>> DictionaryRegionsSecondNames { get; } = new Dictionary<ERegion, List<string>>()
            {
                { ERegion.BR, new List<string>
                    {
                        "Silva", "Santos", "Oliveira", "Souza", "Pereira", "Costa", "Rodrigues", "Almeida",
                        "Lima", "Carvalho"
                    }
                },

                { ERegion.US, new List<string>
                    {
                        "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez"
                    }
                }
            };
    }
}
