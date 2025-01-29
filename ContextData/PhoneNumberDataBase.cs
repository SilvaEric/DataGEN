using GeradorDadosAPI.Enums;

namespace GeradorDadosAPI.ContextData
{
    public class PhoneNumberDataBase
    {
        public Dictionary<ERegion, string> CountryCodes { get; } = new Dictionary<ERegion, string>
            {
                {ERegion.BR, "+55"},
                {ERegion.US, "+1" },
            };

        public Dictionary<EStatesBR, List<string>> BRAreaCodes { get; } = new Dictionary<EStatesBR, List<string>>
            {
                { EStatesBR.AC, new List<string> { "68" } },
                { EStatesBR.AL, new List<string> { "82" } },
                { EStatesBR.AM, new List<string> { "92", "97" } },
                { EStatesBR.AP, new List<string> { "96" } },
                { EStatesBR.BA, new List<string> { "71", "73", "74", "75", "77" } },
                { EStatesBR.CE, new List<string> { "85", "88" } },
                { EStatesBR.DF, new List<string> { "61" } },
                { EStatesBR.ES, new List<string> { "27", "28" } },
                { EStatesBR.GO, new List<string> { "62", "64" } },
                { EStatesBR.MA, new List<string> { "98", "99" } },
                { EStatesBR.MG, new List<string> { "31", "32", "33", "34", "35", "37", "38" } },
                { EStatesBR.MS, new List<string> { "67" } },
                { EStatesBR.MT, new List<string> { "65", "66" } },
                { EStatesBR.PA, new List<string> { "91", "93", "94" } },
                { EStatesBR.PB, new List<string> { "83" } },
                { EStatesBR.PE, new List<string> { "81", "87" } },
                { EStatesBR.PI, new List<string> { "86", "89" } },
                { EStatesBR.PR, new List<string> { "41", "42", "43", "44", "45", "46" } },
                { EStatesBR.RJ, new List<string> { "21", "22", "24" } },
                { EStatesBR.RN, new List<string> { "84" } },
                { EStatesBR.RO, new List<string> { "69" } },
                { EStatesBR.RR, new List<string> { "95" } },
                { EStatesBR.RS, new List<string> { "51", "53", "54", "55" } },
                { EStatesBR.SC, new List<string> { "47", "48", "49" } },
                { EStatesBR.SE, new List<string> { "79" } },
                { EStatesBR.SP, new List<string> { "11", "12", "13", "14", "15", "16", "17", "18", "19" } },
                { EStatesBR.TO, new List<string> { "63" } }
            };
        public Dictionary<EStatesUS, List<string>> USAreaCodes { get; } = new Dictionary<EStatesUS, List<string>>
            {
                { EStatesUS.AL, new List<string> { "205", "251", "256", "334", "938" } },
                { EStatesUS.AK, new List<string> { "907" } },
                { EStatesUS.AZ, new List<string> { "480", "520", "602", "623", "928" } },
                { EStatesUS.AR, new List<string> { "479", "501", "870" } },
                { EStatesUS.CA, new List<string> { "209", "213", "310", "323", "408", "415", "424", "442", "510", "530", "559", "562", "619", "626", "628", "650", "657", "661", "669", "707", "714", "747", "760", "805", "818", "820", "831", "858", "909", "916", "925", "949", "951" } },
                { EStatesUS.CO, new List<string> { "303", "719", "720", "970" } },
                { EStatesUS.CT, new List<string> { "203", "475", "860", "959" } },
                { EStatesUS.DE, new List<string> { "302" } },
                { EStatesUS.DC, new List<string> { "202" } },
                { EStatesUS.FL, new List<string> { "239", "305", "321", "352", "386", "407", "561", "727", "754", "772", "786", "813", "850", "863", "904", "941", "954" } },
                { EStatesUS.GA, new List<string> { "229", "404", "470", "478", "678", "706", "762", "770", "912" } },
                { EStatesUS.HI, new List<string> { "808" } },
                { EStatesUS.ID, new List<string> { "208", "986" } },
                { EStatesUS.IL, new List<string> { "217", "224", "309", "312", "331", "618", "630", "708", "773", "779", "815", "847", "872" } },
                { EStatesUS.IN, new List<string> { "219", "260", "317", "463", "574", "765", "812", "930" } },
                { EStatesUS.IA, new List<string> { "319", "515", "563", "641", "712" } },
                { EStatesUS.KS, new List<string> { "316", "620", "785", "913" } },
                { EStatesUS.KY, new List<string> { "270", "364", "502", "606", "859" } },
                { EStatesUS.LA, new List<string> { "225", "318", "337", "504", "985" } },
                { EStatesUS.ME, new List<string> { "207" } },
                { EStatesUS.MD, new List<string> { "227", "240", "301", "410", "443", "667" } },
                { EStatesUS.MA, new List<string> { "339", "351", "413", "508", "617", "774", "781", "857", "978" } },
                { EStatesUS.MI, new List<string> { "231", "248", "269", "313", "517", "586", "616", "679", "734", "810", "906", "947", "989" } },
                { EStatesUS.MN, new List<string> { "218", "320", "507", "612", "651", "763", "952" } },
                { EStatesUS.MS, new List<string> { "228", "601", "662", "769" } },
                { EStatesUS.MO, new List<string> { "314", "417", "573", "636", "660", "816" } },
                { EStatesUS.MT, new List<string> { "406" } },
                { EStatesUS.NE, new List<string> { "308", "402", "531" } },
                { EStatesUS.NV, new List<string> { "702", "725", "775" } },
                { EStatesUS.NH, new List<string> { "603" } },
                { EStatesUS.NJ, new List<string> { "201", "551", "609", "732", "848", "856", "862", "908", "973" } },
                { EStatesUS.NM, new List<string> { "505", "575" } },
                { EStatesUS.NY, new List<string> { "212", "315", "332", "347", "516", "518", "585", "607", "631", "646", "680", "716", "718", "845", "914", "917", "929", "934" } },
                { EStatesUS.NC, new List<string> { "252", "336", "704", "743", "828", "910", "919", "980", "984" } },
                { EStatesUS.ND, new List<string> { "701" } },
                { EStatesUS.OH, new List<string> { "216", "220", "234", "330", "419", "440", "513", "567", "614", "740", "937" } },
                { EStatesUS.OK, new List<string> { "405", "539", "580", "918" } },
                { EStatesUS.OR, new List<string> { "458", "503", "541", "971" } },
                { EStatesUS.PA, new List<string> { "215", "223", "267", "272", "412", "445", "484", "570", "610", "717", "724", "814", "878" } },
                { EStatesUS.RI, new List<string> { "401" } },
                { EStatesUS.SC, new List<string> { "803", "843", "854", "864" } },
                { EStatesUS.SD, new List<string> { "605" } },
                { EStatesUS.TN, new List<string> { "423", "615", "629", "731", "865", "901", "931" } },
                { EStatesUS.TX, new List<string> { "210", "214", "254", "281", "325", "346", "361", "409", "430", "432", "469", "512", "682", "713", "726", "737", "806", "817", "830", "832", "903", "915", "936", "940", "956", "972", "979" } },
                { EStatesUS.UT, new List<string> { "385", "435", "801" } },
                { EStatesUS.VT, new List<string> { "802" } },
                { EStatesUS.VA, new List<string> { "276", "434", "540", "571", "703", "757", "804" } },
                { EStatesUS.WA, new List<string> { "206", "253", "360", "425", "509", "564" } },
                { EStatesUS.WV, new List<string> { "304", "681" } },
                { EStatesUS.WI, new List<string> { "262", "414", "534", "608", "715", "920" } },
                { EStatesUS.WY, new List<string> { "307" } }
            };
    }
}
