namespace GeradorDadosAPI.Models
{
    public class CreditCard
    {
        public int CardNumber { get; set; }
        public DateOnly ExpirationDate { get; set; }
        public int CVV { get; set; }
    }
}