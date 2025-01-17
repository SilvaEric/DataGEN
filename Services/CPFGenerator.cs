using GeradorDadosAPI.Models;

namespace GeradorDadosAPI.Services
{
    public class CPFGenerator : IGenerator
    {
        public void Generate(CustomizableSelections selections, PersonDataBase person)
        {
            //Lógica de Criação do CPF
        }

        public bool Validate(int generatedCPF)
        {
            //Lógica de validação

            return false;
        }
    }
}