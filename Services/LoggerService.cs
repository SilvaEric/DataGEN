
using GeradorDadosAPI.Models;
using Serilog.Context;
using Serilog.Events;

namespace GeradorDadosAPI.Services
{
    public class LoggerService
    {
        private readonly Serilog.ILogger _logger;

        public LoggerService(Serilog.ILogger logger)
        {
            _logger = logger;
        }

        public void SetLog(LogEventLevel logLevel, string message)
        {
            _logger.Write(logLevel, message);
            LogContext.Reset();
        }
        public void SetLogContext(string key, object value)
        {
            LogContext.PushProperty( key, value, true);
        }
    }
}
