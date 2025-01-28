using GeradorDadosAPI.Models;
using GeradorDadosAPI.Services.Interfaces;

namespace GeradorDadosAPI.Services.Generators
{
    public class AgeGenerator : IAgeGenerator
    {
        private readonly DateOnly today = DateOnly.FromDateTime(DateTime.UtcNow);
        public DateOnly GenerateBirthDate()
        {
            DateOnly startDate = new DateOnly(today.Year - 80, 1, 1);
            DateOnly endDate = new DateOnly(today.Year - 18, today.Month, today.Day);

            var random = new Random();

            int range = endDate.DayNumber - startDate.DayNumber;
            int randomDays = random.Next(range);

            return startDate.AddDays(randomDays);
        }

        public int CalculateAge(DateOnly birthDate)
        {
            int age = today.Year - birthDate.Year;

            if (today < birthDate.AddYears(age))
                age--;

            return age;
        }

        public DateOnly GetBirthDate(int age)
        {
            return new DateOnly(today.Year - age, today.Month, today.Day);
        }
    }
}
