using GeradorDadosAPI.Enums;

namespace GeradorDadosAPI.ContextData
{
    public class NamesDataBase
    {
        public Dictionary<ERegion, Dictionary<string, List<string>>> DictionaryRegionsNames { get; set; } = new Dictionary<ERegion, Dictionary<string, List<string>>>();

        public NamesDataBase()
        {
            DictionaryRegionsNames = new Dictionary<ERegion, Dictionary<string, List<string>>>
            {
                {
                    ERegion.BR, new Dictionary<string, List<string>>
                    {
                        { "Male", new List<string> 
                            { 
                                "João", "Pedro", "Carlos", "Francisco", "José", "Lucas", "Gabriel", "Matheus", "Felipe", "Rafael" 
                            } 
                        },

                        { "Female", new List<string> 
                            { 
                                "Ana", "Maria", "Mariana", "Beatriz", "Vitória", "Luiza", "Julia", "Camila", "Larissa", "Gabriela", "Laura" 
                            } 
                        }
                    }
                },

                {
                    ERegion.UK, new Dictionary<string, List<string>>
                    {
                        { "Male", new List<string> 
                            { 
                                "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Charles", "Thomas" 
                            } 
                        },

                        { "Female", new List<string> 
                            { 
                                "Emma", "Olivia", "Ava", "Isabella", "Sophia", "Amelia", "Grace", "Chloe", "Lily", "Evelyn" 
                            } 
                        }
                    }
                },

                {
                    ERegion.US, new Dictionary<string, List<string>>
                    {
                        { "Male", new List<string> 
                            { 
                                "Christopher", "Matthew", "Anthony", "Mark", "Donald", "Steven", "Paul", "Andrew", "Joshua", "Daniel" 
                            } 
                        },

                        { "Female", new List<string> 
                            { 
                                "Mary", "Patricia", "Jennifer", "Linda", "Elizabeth", "Barbara", "Susan", "Jessica", "Sarah", "Karen" 
                            } 
                        }
                    }
                },

                {
                    ERegion.AS, new Dictionary<string, List<string>>
                    {
                        { "Male", new List<string> 
                            { 
                                "Li", "Wang", "Zhang", "Liu", "Chen", "Yang", "Haruto", "Yuto", "Sota", "Daiki", "Ryusei" 
                            } 
                        },
                        
                        { "Female", new List<string> 
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
