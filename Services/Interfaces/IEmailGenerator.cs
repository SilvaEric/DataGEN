using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;

namespace GeradorDadosAPI.Services.Interfaces
{
    public interface IEmailGenerator
    {
        public string Generate(string name);
    }
}
