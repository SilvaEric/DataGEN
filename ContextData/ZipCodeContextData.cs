using GeradorDadosAPI.Enums;

namespace GeradorDadosAPI.ContextData
{
    public class ZipCodeContextData
    {
        public Dictionary<EStatesBR, int[]> ZipCodesByStatesBR { get; } = new Dictionary<EStatesBR, int[]>()
        {
            { EStatesBR.SP, new int[2] {01000001, 19999999} },
            { EStatesBR.RJ, new int[2] {20000001, 28999999} },
            { EStatesBR.ES, new int[2] {29000001, 29999999} },
            { EStatesBR.MG, new int[2] {30000001, 39997999} },
            { EStatesBR.BA, new int[2] {40000001, 48999999} },
            { EStatesBR.SE, new int[2] {49000001, 49999999} },
            { EStatesBR.PE, new int[2] {50000001, 56999999} },
            { EStatesBR.AL, new int[2] {57000001, 57999999} },
            { EStatesBR.PB, new int[2] {58000001, 58996999} },
            { EStatesBR.RN, new int[2] {59000001, 59999999} },
            { EStatesBR.CE, new int[2] {60000001, 63999999} },
            { EStatesBR.PI, new int[2] {64000001, 64999999} },
            { EStatesBR.MA, new int[2] {65000001, 65999999} },
            { EStatesBR.PA, new int[2] {66000001, 68899999} },
            { EStatesBR.AP, new int[2] {68900001, 68999999} },
            { EStatesBR.AM, new int[4] {69000001, 69299999, 69400001, 69899999 } },
            { EStatesBR.RR, new int[2] {69300001, 69399999} },
            { EStatesBR.AC, new int[2] {69900001, 69999999} },
            { EStatesBR.DF, new int[2] {70000001, 72799999} },
            { EStatesBR.GO, new int[2] {72800001, 76759999} },
            { EStatesBR.RO, new int[2] {76800001, 76999999} },
            { EStatesBR.TO, new int[2] {77000001, 77999999} },
            { EStatesBR.MT, new int[2] {78000001, 78899999} },
            { EStatesBR.MS, new int[2] {79000001, 79999999} },
            { EStatesBR.PR, new int[2] {80000001, 87999999} },
            { EStatesBR.SC, new int[2] {88000001, 89999999} },
            { EStatesBR.RS, new int[2] {90000001, 99999999} },
        };
    }
}
