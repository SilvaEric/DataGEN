namespace GeradorDadosAPI.ContextData
{
    public class BloodTypeDataBase
    {
        public List<string> BloodTypes { get; } = new List<string>(["A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-"]);

    }
}
