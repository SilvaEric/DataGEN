using GeradorDadosAPI.Enums;

namespace GeradorDadosAPI.ContextData
{
    public class NamesDataBase
    {
        public Dictionary<ERegion, Dictionary<EGender, List<string>>> DictionaryRegionsNames { get; } = new Dictionary<ERegion, Dictionary<EGender, List<string>>>
            {
                {
                    ERegion.BR, new Dictionary<EGender, List<string>>
                    {
                        { EGender.MALE, new List<string>
                            {
                                "João", "Pedro", "Carlos", "Francisco", "José", "Lucas", "Gabriel", "Matheus", "Felipe", "Rafael"
                            }
                        },

                        { EGender.FEMALE, new List<string>
                            {
                                "Ana", "Maria", "Mariana", "Beatriz", "Vitória", "Luiza", "Julia", "Camila", "Larissa", "Gabriela", "Laura"
                            }
                        }
                    }
                },

                {
                    ERegion.US, new Dictionary<EGender, List<string>>
                    {
                        { EGender.MALE, new List<string>
                            {
                                "Christopher", "Matthew", "Anthony", "Mark", "Donald", "Steven", "Paul", "Andrew", "Joshua", "Daniel"
                            }
                        },

                        { EGender.FEMALE, new List<string>
                            {
                                "Mary", "Patricia", "Jennifer", "Linda", "Elizabeth", "Barbara", "Susan", "Jessica", "Sarah", "Karen"
                            }
                        }
                    }
                }
            };
    }
}
