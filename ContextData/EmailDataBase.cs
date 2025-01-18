namespace GeradorDadosAPI.ContextData
{
    public class EmailDataBase
    {
        public List<string> EmailsDomains { get; set; } = new List<string>
            (
                ["@gmail.com", "@hotmail.com", "@outlook.com", "@yahoo.com", "@icloud.com", "@protonmail.com", 
                "@mail.com", "@yandex.com", "@zoho.com", "@aol.com"]
            );
    }
}
