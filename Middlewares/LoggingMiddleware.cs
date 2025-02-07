using GeradorDadosAPI.Models;
using GeradorDadosAPI.Services;

namespace GeradorDadosAPI.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly LoggerService _logger;

        public LoggingMiddleware(RequestDelegate next, LoggerService logger) 
        { 
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next(context);

            var responseDetails = new ResponseDetails(context);
            _logger.SetLogContext("ResponseDetails", responseDetails);

            
            if (context.Response.StatusCode < 300)
            {
                _logger.SetLog(Serilog.Events.LogEventLevel.Information, "User gets Sucessful response");
            }
            else if (context.Response.StatusCode < 500)
            {
                _logger.SetLog(Serilog.Events.LogEventLevel.Warning, "Error generated on the Client-Side");
            }
            else
            {
                _logger.SetLog(Serilog.Events.LogEventLevel.Error, "Error generated on the Server-Side");
            }
        }
    }
}
