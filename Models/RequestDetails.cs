using System.Security.Principal;

namespace GeradorDadosAPI.Models
{
    public class RequestDetails
    {
        public string Method { get; set; }
        public string Endpoint { get; set; }
        public string UserIp { get; set; }
        public CustomizableSelections UserInput { get; set; }

        public RequestDetails(HttpContext httpContext, CustomizableSelections userInput)
        {
            Method = httpContext.Request.Method;
            Endpoint = httpContext.Request.Path ;
            UserIp = httpContext.Connection.RemoteIpAddress?.ToString() ?? "Unknown";
            UserInput = userInput;
        }
    }
}
