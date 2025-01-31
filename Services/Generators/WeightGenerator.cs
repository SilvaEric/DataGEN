namespace GeradorDadosAPI.Services.Generators
{
    public class WeightGenerator : IGenerateNoParams
    {
        public object Generate()
        {
            var random = new Random();

            return Math.Round(30.0 + (random.NextDouble() * 90), 2);
        }
    }
}
