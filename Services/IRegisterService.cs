using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;

namespace GeradorDadosAPI.Services
{
    public interface IRegisterService
    {
        public void Register(PersonBase person, CustomizableSelections customizableSelections);
    }
}
