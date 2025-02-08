using GeradorDadosAPI.Enums;

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
        public Address? Address { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public string? BloodType { get; set; }

        public virtual PersonBase GeneratePerson(CustomizableSelections selections)
        {
            return this;
        }
 
    }
}
