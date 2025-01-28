using GeradorDadosAPI.Enums;

namespace GeradorDadosAPI.ContextData
{
    public class NamesDataBase
    {
        public Dictionary<ERegion, Dictionary<EGender, List<string>>> DictionaryRegionsNames { get; set; } = new Dictionary<ERegion, Dictionary<EGender, List<string>>>();

        public NamesDataBase()
        {
            DictionaryRegionsNames = new Dictionary<ERegion, Dictionary<EGender, List<string>>>
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
                    ERegion.UK, new Dictionary<EGender, List<string>>
                    {
                        { EGender.MALE, new List<string> 
                            { 
                                "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Charles", "Thomas" 
                            } 
                        },

                        { EGender.FEMALE, new List<string> 
                            { 
                                "Emma", "Olivia", "Ava", "Isabella", "Sophia", "Amelia", "Grace", "Chloe", "Lily", "Evelyn" 
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
                },

                {
                    ERegion.AS, new Dictionary<EGender, List<string>>
                    {
                        { EGender.MALE, new List<string> 
                            { 
                                "Li", "Wang", "Zhang", "Liu", "Chen", "Yang", "Haruto", "Yuto", "Sota", "Daiki", "Ryusei" 
                            } 
                        },
                        
                        { EGender.FEMALE, new List<string> 
                            { 
                                "Aarav", "Vivaan", "Aditya", "Sai", "Ishaan", "Ren", "Mohan", "Shaurya", "Yash", "Kartik" 
                            } 
                        }
                    }
                }
            };
        }
    }
}
