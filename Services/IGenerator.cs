using GeradorDadosAPI.ContextData;
using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using System.Runtime.CompilerServices;

namespace GeradorDadosAPI.Services
{
    public interface IGenerator
    {
        public void Generate(CustomizableSelections selections, PersonDataBase person);
    }
}
