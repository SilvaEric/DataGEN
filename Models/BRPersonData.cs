using GeradorDadosAPI.Services;
using System.ComponentModel.DataAnnotations;

namespace GeradorDadosAPI.Models
{
    public class BRPersonData : PersonDataBase
    {
        private readonly Dictionary<string , IGenerator> BrGenerators = new()
        {
            {"CPF", new CPFGenerator() },
            /*{"RG", new RGGenerator() },
            {"CNH", new CNHGenerator() },
            {"CertidãoNasc", new BirthCertificateGenerator() },
            {"CertidãoCas", new MarriageCertificateGenerator() },
            {"CertidãoObt", new DeathCertificateGenerator() },
            {"PIS", new PISGenerator() },
            {"TituloEleitor", new VoterCardGenerator() },
            {"CreditCard", new CreditCardGenerator() },
            {"CNPJ", new CNPJGenerator() }*/
        };
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

        public override BRPersonData GeneratePerson(CustomizableSelections selections)
        {
            base.GeneratePerson(selections);

            foreach (var selection in selections.SelectedDatas)
            {
                if (BrGenerators.TryGetValue(selection, out var generator))
                    generator.Generate(selections, this);
            }
            return this;
        }
    }
}
