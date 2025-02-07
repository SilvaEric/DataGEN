using System.Net;

namespace GeradorDadosAPI.Models
{
    public class ResponseDetails
    {
        public int StatusCode { get; set; }
        public string Result { get; set; }
        public object ResponseBody { get; set; }

        public ResponseDetails(HttpContext context)
        {
            StatusCode = context.Response.StatusCode;
            Result = ((HttpStatusCode)StatusCode).ToString();
            ResponseBody = context.Response.Body;
        }
    }
}
