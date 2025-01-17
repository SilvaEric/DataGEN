using GeradorDadosAPI.Enums;

namespace GeradorDadosAPI.Models
{
    public class CustomizableSelections
    {
        public ERegion Region { get; set; }
        public List<string> SelectedDatas { get; set; }
        public int Quantity { get; set; }

        public CustomizableSelections(ERegion region, List<string> selectedDatas, int quantity)
        {
            Region = region;
            SelectedDatas = selectedDatas;
            Quantity = quantity;
        }
    }
}
