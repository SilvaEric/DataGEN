using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;

namespace GeradorDadosAPI.Services.Interfaces
{
    public interface IRegisterService
    {
        public void Register(PersonBase person, CustomizableSelections customizableSelections);

        public PersonBase GetPersonGenerator(ERegion region);
    }
}
