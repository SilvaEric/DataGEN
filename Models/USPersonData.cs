namespace GeradorDadosAPI.Models
{
    public class USPersonData : PersonDataBase
    {
        public override PersonDataBase GeneratePerson(CustomizableSelections selections)
        {
            base.GeneratePerson(selections);
            return this;
        }
    }
}
