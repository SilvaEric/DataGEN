using GeradorDadosAPI.Enums;
using System.Globalization;

namespace GeradorDadosAPI.Models
{
    public abstract class PersonDataBase
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public int? age { get; set; }
        public DateOnly? nasc_date { get; set; }
        public string? gender { get; set; }
        public string? mother { get; set; }
        public string? father { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public int? phone { get; set; }
        public int? zipCode { get; set; }
        public string? adress { get; set; }
        public int? number { get; set; }
        public string? neighborhood { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? country { get; set; }
        public float? height { get; set; }
        public float? weight { get; set; }
        public string? blood_type { get; set; }
        public abstract PersonDataBase GeneratePerson(CustomizableSelections Selections);
    }
}
