using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Services.Interfaces;

namespace GeradorDadosAPI.Models
{
    public class USPersonData : PersonBase
    {
        private readonly IRegisterService _registerService;
        public USPersonData(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        public override USPersonData GeneratePerson(CustomizableSelections selections)
        { 
            _registerService.Register(this, selections);
            return this;
        }
    }
}
