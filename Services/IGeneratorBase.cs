using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;

namespace GeradorDadosAPI.Services
{
    public interface IGeneratorBase
    {
       public object Generate(ERegion region);
    }
}
