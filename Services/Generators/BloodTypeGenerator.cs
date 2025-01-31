using GeradorDadosAPI.ContextData;

namespace GeradorDadosAPI.Services.Generators
{
    public class BloodTypeGenerator : IGenerateNoParams
    {
        private readonly BloodTypeDataBase _bloodTypeData;

        public BloodTypeGenerator(BloodTypeDataBase bloodTypeData)
        {
            _bloodTypeData = bloodTypeData;
        }
        public object Generate()
        {
            var random = new Random();

            var listBloodType = _bloodTypeData.BloodTypes;

            return listBloodType[random.Next(listBloodType.Count)];
        }
    }
}
