namespace GeradorDadosAPI.Models
{
    public class ASPersonData : PersonDataBase
    {
        public override PersonDataBase GeneratePerson(CustomizableSelections Selections)
        {
            base.GeneratePerson(Selections);
            return this;
        }
    }
}
