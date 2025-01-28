using GeradorDadosAPI.Enums;

namespace GeradorDadosAPI.Models
{
    public class CustomizableSelections
    {
        public EGender? Gender { get; set; }
        public int? Age { get; set; }
        public ERegion Region { get; set; }
        public List<string> SelectedDatas { get; set; }
        public int Quantity { get; set; }

        public CustomizableSelections(EGender? gender, int? age, ERegion region, List<string> selectedDatas, int quantity)
        {
            if (gender.HasValue)
                Gender = gender.Value;
            if (age.HasValue)
                Age = age.Value;
            Region = region;
            SelectedDatas = selectedDatas;
            Quantity = quantity;
        }
    }
}
