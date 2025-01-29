namespace GeradorDadosAPI.ContextData
{
    public class CharListsDataBase
    {
        public List<char> LowercasesLetters { get; } = new List<char>(
            ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'o', 'p', 'q','r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
        );
        public List<char> Symbols { get; } = new List<char>(
            ['!', '@', '#', '$', '%', '¨', '&', '*', '(', ')', '+', '=', '_', '§',
            'ª', 'º', '{', '}', '[', ']']
        );
        public List<char> Numbers { get; } = new List<char>(
            ['1', '2', '3', '4', '5', '6', '7', '8', '9', '0']
        );
    }
}
