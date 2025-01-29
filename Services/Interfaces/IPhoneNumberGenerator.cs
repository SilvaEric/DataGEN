using GeradorDadosAPI.ContextData;
using GeradorDadosAPI.Enums;
using Microsoft.Net.Http.Headers;

namespace GeradorDadosAPI.Services.Generators
{
    public interface IPhoneNumberGenerator
    {
        public string GenerateBRPhone(ERegion region, EStatesBR stateBR);
        public string GenerateUSPhone(ERegion region, EStatesUS stateUS);
    }
}
