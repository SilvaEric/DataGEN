using GeradorDadosAPI.Enums;
using Microsoft.Extensions.Hosting;

namespace GeradorDadosAPI.ContextData
{
    public class SecondNamesDataBase
    {
        public Dictionary<ERegion, List<string>> DictionaryRegionsSecondNames { get; set; } = new Dictionary<ERegion, List<string>>();

        public SecondNamesDataBase()
        {
            DictionaryRegionsSecondNames = new Dictionary<ERegion, List<string>>()
            {
                { ERegion.BR, new List<string> { "Silva", "Santos", "Oliveira", "Souza", "Pereira", "Costa", "Rodrigues", "Almeida", 
                    "Lima", "Carvalho" } },

                { ERegion.UK, new List<string> { "Smith", "Jones", "Taylor", "Brown", "Williams", "Wilson", "Johnson", "Davies", 
                    "Evans", "Thomas", "Müller", "Schmidt", "Schneider", "Fischer", "Weber", "Meyer", "Wagner", "Becker", "Hoffmann", 
                    "Zimmermann","Martin","Bernard","Dubois","Thomas","Robert","Richard","Petit","Durand","Leroy","Lefevre" } },

                { ERegion.US, new List<string> { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez" } },

                { ERegion.AS, new List<string> { "Wang", "Li", "Zhang", "Liu", "Chen", "Yang", "Huang", "Zhao", "Wu", "Xu", "Sharma", 
                    "Patel", "Gupta", "Singh", "Kumar", "Reddy", "Joshi", "Mehta", "Iyer", "Das", "Sato","Suzuki","Takahashi","Tanaka",
                    "Watanabe","Ito","Yamamoto","Nakamura","Kobayashi","Kato" } }
            };
        }
    }
}
