using GeradorDadosAPI.ContextData;
using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using GeradorDadosAPI.Services.Interfaces;

namespace GeradorDadosAPI.Services.Generators
{
    public class EmailGenerator : IEmailGenerator
    {
        public string Generate(string name)
        {
            var names = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var random = new Random();
            var number = random.Next(1, 2050);
            var listMailDomains = new EmailDataBase().EmailsDomains;
            var selectedMailDomain = listMailDomains[random.Next(listMailDomains.Count)];

            return $"{names[0]}{names[1]}{number}{selectedMailDomain}";
        }
    }
}
