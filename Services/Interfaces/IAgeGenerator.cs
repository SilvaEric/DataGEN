
namespace GeradorDadosAPI.Services.Interfaces
{
    public interface IAgeGenerator
    {
        public DateOnly GenerateBirthDate();
        public int CalculateAge(DateOnly dateOnly);
        public DateOnly GetBirthDate(int age);
    }
}
