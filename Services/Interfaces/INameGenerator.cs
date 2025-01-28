using GeradorDadosAPI.Enums;

namespace GeradorDadosAPI.Services.Interfaces
{
    public interface INameGenerator
    {
        public string Generate(EGender? gender, ERegion region);
    }
}
