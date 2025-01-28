using GeradorDadosAPI.Services;

namespace GeradorDadosAPI.Models
{
    public class USPersonData : PersonBase
    {
        private readonly IRegisterService _registerService;
        public USPersonData(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        public override PersonBase GeneratePerson(CustomizableSelections selections)
        {
            _registerService.Register(this, selections);
            return this;
        }
    }
}
