namespace GeradorDadosAPI.Services.Generators
{
    public class HeightGenerator : IGenerateNoParams
    {
        public object Generate()
        {
            var random = new Random();

            return Math.Round(1.40 + (random.NextDouble() * 0.70), 2);
        }
    }
}
