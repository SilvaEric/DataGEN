using GeradorDadosAPI.ContextData;

namespace GeradorDadosAPI.Services.Generators
{
    public class PasswordGenerator : IPasswordGenerator
    {
        private readonly CharListsDataBase _charLists;

        public PasswordGenerator(CharListsDataBase data)
        {
            _charLists = data;
        }
        public string Generate()
        {
            var random = new Random();
            int charQuantity = random.Next(12, 20);
            string password = "";

            int historySave1 = 0, historySave2 = 0, historySave3 = 0, historySave4 = 0;

            for ( var i = 0; i<charQuantity; i++)
            {
                int select = random.Next(1,5);

                if ( i>0 && i % 3 == 0)
                {
                    if (historySave1 == 0)
                        select = 1;

                    if (historySave2 == 0)
                        select = 2;

                    if (historySave3 == 0)
                        select = 3;

                    if (historySave4 == 0)
                        select = 4;
                }

                switch(select)
                {
                    case 1:
                        int lowercaseIndex = random.Next(_charLists.LowercasesLetters.Count);
                        password += _charLists.LowercasesLetters[lowercaseIndex];
                        historySave1++;
                        break;

                    case 2:
                        int uppercasesIndex = random.Next(_charLists.LowercasesLetters.Count);
                        var uppercasesLetters = _charLists.LowercasesLetters.Select(char.ToUpper).ToList();
                        password += uppercasesLetters[uppercasesIndex];
                        historySave2++; 
                        break;

                    case 3:
                        int numbersIndex = random.Next(_charLists.Numbers.Count);
                        password +=_charLists.Numbers[numbersIndex];
                        historySave3++;
                        break;

                    case 4:
                        int symbolsIndex = random.Next(_charLists.Symbols.Count);
                        password += _charLists.Symbols[symbolsIndex];
                        historySave4++;
                        break;

                }

            }

            return password;
        }
    }
}
