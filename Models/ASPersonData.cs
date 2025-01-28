using GeradorDadosAPI.Services;

namespace GeradorDadosAPI.Models
{
    public class ASPersonData : PersonBase
    {
        private readonly IRegisterService _registerService;
        public ASPersonData(IRegisterService registerService)
        {
            _registerService = registerService;
        }
        
        public override PersonBase GeneratePerson(CustomizableSelections Selections)
        {
            _registerService.Register(this, Selections);
            return this;
        }
    }
}
