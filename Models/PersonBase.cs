using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Services;
using GeradorDadosAPI.Services.Generators;
using System.Globalization;

namespace GeradorDadosAPI.Models
{
    public class PersonBase
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public DateOnly? NascDate { get; set; }
        public EGender? Gender { get; set; }
        public string? Mother { get; set; }
        public string? Father { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public int? ZipCode { get; set; }
        public string? Adress { get; set; }
        public int? Number { get; set; }
        public string? Neighborhood { get; set; }
        public string? City { get; set; }
        public string State { get; set; }
        public string? Country { get; set; }
        public float? Height { get; set; }
        public float? Weight { get; set; }
        public string? BloodType { get; set; }

        public virtual PersonBase GeneratePerson(CustomizableSelections selections)
        {
            return this;
        }
 
    }
}
