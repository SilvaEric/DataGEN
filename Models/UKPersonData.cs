namespace GeradorDadosAPI.Models
{
    public class UKPersonData : PersonDataBase
    {
        public override UKPersonData GeneratePerson(CustomizableSelections selections)
        {
            base.GeneratePerson(selections);

            return this;
        }
    }
}
