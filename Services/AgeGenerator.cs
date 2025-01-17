using GeradorDadosAPI.Models;

namespace GeradorDadosAPI.Services
{
    public class AgeGenerator : IGenerator
    {
        public void Generate(CustomizableSelections selections, PersonDataBase person)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.UtcNow);
            DateOnly startDate = new DateOnly(today.Year - 90, 1, 1);
            DateOnly endDate = new DateOnly(today.Year - 18, today.Month, today.Day);
            var random = new Random();
            
            int range = startDate.DayNumber - endDate.DayNumber;

            int randomDays = random.Next(range);

            var birthDate = startDate.AddDays(randomDays);

            int age = today.Year - birthDate.Year;

            if (today < birthDate.AddYears(age))
                age--;

            person.NascDate = birthDate;
            person.Age = age;
        }
    }
}
