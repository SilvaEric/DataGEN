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
                { ERegion.BR, new List<string> { "Ana", "Maria", "João", "Pedro", "Carlos", "Francisco", "José", "Lucas", "Gabriel", 
                    "Mariana", "Felipe", "Rafael", "Beatriz", "Vitória", "Luiza", "Julia", "Camila", "Larissa", "Gabriela", "Matheus", "Laura" } },

                { ERegion.UK, new List<string> { "Emma", "Olivia", "Ava", "Isabella", "Sophia", "Mia", "Amelia", "Harper", "Evelyn", "Abigail", 
                    "Ella", "Scarlett", "Grace", "Lily", "Aria", "Chloe", "Isla", "Zoey", "Nora", "Mila", "Emma", "Mia", "Hannah", "Anna", "Lina", 
                    "Sophia", "Lea", "Marie", "Mila", "Lena", "Clara", "Amelie", "Luisa", "Charlotte", "Emily", "Sara", "Sofia", "Johanna", "Lisa", 
                    "Kim", "Emma", "Léa", "Chloé", "Lola", "Inès", "Manon", "Camille", "Alice", "Jade", "Lou", "Julie", "Lucie", "Sarah", "Lina", 
                    "Marie", "Zoe", "Clara", "Anaïs", "Eva", "Mélanie" } },

                { ERegion.US, new List<string> { "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Charles", 
                    "Thomas", "Christopher", "Daniel", "Matthew", "Anthony", "Mark", "Donald", "Steven", "Paul", "Andrew", "Joshua" } },

                { ERegion.AS, new List<string> { "Li", "Wang", "Zhang", "Liu", "Chen", "Yang", "Huang", "Zhao", "Wu", "Xu", "Sun", "Ma", "Zhou", 
                    "Huo", "Guo", "Lin", "Luo", "He", "Liang", "Tang", "Aarav", "Vivaan", "Aditya", "Sai", "Ishaan", "Arjun", "Vihaan", "Reyansh", 
                    "Ayaan", "Krishna", "Rohan", "Om", "Aryan", "Kabir", "Mohan", "Shaurya", "Yash", "Abhinav", "Kartik", "Raj", "Ren", "Haruto", 
                    "Yuto", "Sota", "Daiki", "Yuki", "Kaito", "Sora", "Haruki", "Riku", "Takuya", "Sho", "Itsuki", "Kenta", "Shunya", "Takumi", 
                    "Ryusei", "Satoshi", "Shuto", "Keita" } }
            };
        }
    }
}
