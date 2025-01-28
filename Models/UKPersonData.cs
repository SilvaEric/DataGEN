using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Services;

namespace GeradorDadosAPI.Models
{
    public class UKPersonData : PersonBase
    {
        private readonly IRegisterService _registerService;
        public UKPersonData(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        public override UKPersonData GeneratePerson(CustomizableSelections selections)
        { 
            _registerService.Register(this, selections);
            return this;
        }
    }
}
