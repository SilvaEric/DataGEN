using GeradorDadosAPI.Enums;

namespace GeradorDadosAPI.Models
{
    public class CustomizableSelections
    {
        public EStatesBR? StatesBR { get; set; }
        public EStatesUS? StatesUS { get; set; }
        public EGender? Gender { get; set; }
        public int? Age { get; set; }
        public ERegion Region { get; set; }
        public List<string> SelectedDatas { get; set; }
        public int Quantity { get; set; }

        public CustomizableSelections(EStatesBR? statesBR, EStatesUS? statesUS, EGender? gender, int? age, ERegion region, List<string> selectedDatas, int quantity)
        {

            if (statesBR.HasValue)
                StatesBR = statesBR.Value;

            if (statesUS.HasValue)
                StatesUS = statesUS.Value;

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
