using GeradorDadosAPI.ContextData;
using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using GeradorDadosAPI.Services.Interfaces;

namespace GeradorDadosAPI.Services.Generators
{
    public class EmailGenerator : IEmailGenerator
    {
        private readonly EmailDataBase _emailDataBase;
        public EmailGenerator(EmailDataBase emailDataBase)
        {
            _emailDataBase = emailDataBase;
        }
        public string Generate(string name)
        {
            var names = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var random = new Random();
            var number = random.Next(1, 2050);
            var emailsDomains = _emailDataBase.EmailsDomains;
            var selectedMailDomain = emailsDomains[random.Next(emailsDomains.Count)];

            return $"{names[0]}{names[1]}{number}{selectedMailDomain}";
        }
    }
}
