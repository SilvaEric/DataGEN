using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Services;
using GeradorDadosAPI.Services.Generators;
using System.ComponentModel.DataAnnotations;

namespace GeradorDadosAPI.Models
{
    public class BRPersonData : PersonBase
    {
        private readonly IRegisterService _registerService;
        public BankAccount? Account { get; set; }
        public int? RG { get; set; }
        public int? CNH { get; set; }
        public int? BirthCertificate { get; set; }
        public int? MarriageCertificate { get; set; }
        public int? DeathCertificate { get; set; }
        public int? PIS { get; set; }
        public int? VoterCard { get; set; }
        public int? CNPJ { get; set; }
        public CreditCard? PersonalCreditCard { get; set; }
        public int? CPF { get; set; }

        public BRPersonData(IRegisterService registerService) 
        {
            _registerService = registerService;
        }

        public override BRPersonData GeneratePerson(CustomizableSelections selections)
        {
            _registerService.Register(this, selections);
            return this;
        }
    }
}
