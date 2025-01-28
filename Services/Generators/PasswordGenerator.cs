namespace GeradorDadosAPI.Services.Generators
{
    public class PasswordGenerator : IPasswordGenerator
    {
        private List<char> _lowercasesLetters { get; } = new List<char>(
            ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 
            'o', 'p', 'q','r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
        );
        private List<char> _symbols { get; } = new List<char>(
            ['!', '@', '#', '$', '%', '¨', '&', '*', '(', ')', '+', '=', '_', '§', 
            'ª', 'º', '{', '}', '[', ']']
        );
        private List<char> _numbers { get; } = new List<char>(
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0']
        );
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
                        int lowercaseIndex = random.Next(_lowercasesLetters.Count);
                        password += _lowercasesLetters[lowercaseIndex];
                        historySave1++;
                        break;

                    case 2:
                        int uppercasesIndex = random.Next(_lowercasesLetters.Count);
                        var uppercasesLetters = _lowercasesLetters.Select(char.ToUpper).ToList();
                        password += uppercasesLetters[uppercasesIndex];
                        historySave2++; 
                        break;

                    case 3:
                        int numbersIndex = random.Next(_numbers.Count);
                        password += _numbers[numbersIndex];
                        historySave3++;
                        break;

                    case 4:
                        int symbolsIndex = random.Next(_symbols.Count);
                        password += _symbols[symbolsIndex];
                        historySave4++;
                        break;

                }

            }

            return password;
        }
    }
}
