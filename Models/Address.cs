namespace GeradorDadosAPI.Models
{
    public class Address
    {
        public int? ZipCode { get; set; }
        public string? PublicPlace { get; set; }
        public int? Number { get; set; }
        public string? Neighborhood { get; set; }
        public string? City { get; set; }
        public string State { get; set; }
        public string? Country { get; set; }
    }
}
