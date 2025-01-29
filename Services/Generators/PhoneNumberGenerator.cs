using GeradorDadosAPI.ContextData;
using GeradorDadosAPI.Enums;
using Microsoft.Net.Http.Headers;

namespace GeradorDadosAPI.Services.Generators
{
    public class PhoneNumberGenerator : IPhoneNumberGenerator
    {
        private readonly PhoneNumberDataBase _phoneNumberDataBase;
        private readonly CharListsDataBase _charListsDataBase;

        public PhoneNumberGenerator(PhoneNumberDataBase phoneNumberDataBase, CharListsDataBase charListsDataBase)
        {
            _phoneNumberDataBase = phoneNumberDataBase;
            _charListsDataBase = charListsDataBase;
        }

        public string GenerateBRPhone(ERegion region, EStatesBR stateBR)
        {
            string phone = "";

            var random = new Random();
            var listNumericCharacters = _charListsDataBase.Numbers;

            phone += _phoneNumberDataBase.CountryCodes[region];

            var listAreaCodes = _phoneNumberDataBase.BRAreaCodes[stateBR];

            phone += listAreaCodes[random.Next(listAreaCodes.Count)];
            phone += "9";

            for (int i = 0; i < 8; i++)
            {
                phone += listNumericCharacters[random.Next(listNumericCharacters.Count)];
            }

            return phone;
        }

        public string GenerateUSPhone(ERegion region, EStatesUS stateUS)
        {
            string phone = "";

            var random = new Random();
            var listNumericCharacters = _charListsDataBase.Numbers;

            phone += _phoneNumberDataBase.CountryCodes[region];
            var listAreaCodes = _phoneNumberDataBase.USAreaCodes[stateUS];
            phone += listAreaCodes[random.Next(listAreaCodes.Count)];

            for (int i = 0; i < 7; i++)
            {
                phone += listNumericCharacters[random.Next(listNumericCharacters.Count)];
            }

            return phone;
        }
    }
}
