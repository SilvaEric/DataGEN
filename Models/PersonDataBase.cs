using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Services;
using System.Globalization;

namespace GeradorDadosAPI.Models
{
    public class PersonDataBase
    {
        private readonly Dictionary<string, IGenerator> Generators = new()
            {
                { "Name", new NameGenerator() },
                { "Age", new AgeGenerator() },
                { "NascDate", new AgeGenerator() },
                { "Gender", new GenderGenerator() },
                { "Mother", new NameGenerator() },
                { "Father", new NameGenerator() },
                { "Email", new EmailGenerator() },
                { "Password", new NameGenerator() },
                { "Phone", new NameGenerator() },
                { "ZipCode", new NameGenerator() },
                { "Adress", new NameGenerator() },
                { "Number", new NameGenerator() },
                { "Neighborhood", new NameGenerator() },
                { "City", new NameGenerator() },
                { "State", new NameGenerator() },
                { "Country", new NameGenerator() },
                { "Height", new NameGenerator() },
                { "Weight", new NameGenerator() },
                { "BloodType", new NameGenerator() }
            };
        public Guid? Id { get; set; } = new Guid();
        public string? Name { get; set; }
        public int? Age { get; set; }
        public DateOnly? NascDate { get; set; }
        public string? Gender { get; set; }
        public string? Mother { get; set; }
        public string? Father { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? Phone { get; set; }
        public int? ZipCode { get; set; }
        public string? Adress { get; set; }
        public int? Number { get; set; }
        public string? Neighborhood { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }
        public string? BloodType { get; set; }

        public virtual PersonDataBase GeneratePerson(CustomizableSelections selections)
        {
            foreach(var selection in selections.SelectedDatas)
            {
                if (Generators.TryGetValue(selection, out var generator))
                    generator.Generate(selections, this);
            }
            return this;
        }
    }
}
