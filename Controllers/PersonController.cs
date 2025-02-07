using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using GeradorDadosAPI.Services;
using GeradorDadosAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GeradorDadosAPI.Controllers
{
    [ApiController]
    [Route("api/person")]
    public class PersonController : ControllerBase
    {
        private readonly IRegisterService _registerService;
        private readonly LoggerService _loggerService;

        public PersonController(IRegisterService registerService, LoggerService loggerService)
        {
            _registerService = registerService;
            _loggerService = loggerService;
        }

        [HttpPost("generate")]
        public IActionResult GeneratePerson(CustomizableSelections customizableSelections)
        {
            _loggerService.SetLogContext("RequestDetails", new RequestDetails(HttpContext, customizableSelections));
            _loggerService.SetLogContext("Environment", Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")?? "Unknow");
            _loggerService.SetLogContext("ServerDetails", new ServerDetails());
            _loggerService.SetLog(Serilog.Events.LogEventLevel.Information, "Usuario fez uma requisição para api/person/generate, iniciando validação dos dados enviados...");

            List<string> validationsErrors = new List<string>();
            if (!customizableSelections.SelectedDatas.Any())
            {
                validationsErrors.Add("Para que a entrada de dados seja válida o parametro 'SelectedDatas' não pode estar vázio");
            }

            if (customizableSelections.Quantity <= 0)
            {
                validationsErrors.Add("Quando informado O parametro 'Quantity' deve ser > 0."); 
            }

            if(customizableSelections.Age.HasValue && customizableSelections.Age <= 0)
            {
                validationsErrors.Add(" Quando informado o parametro 'Age' deve ser > 0.");
            }

            if (customizableSelections.StatesBR.HasValue && customizableSelections.Region != ERegion.BR || customizableSelections.StatesUS.HasValue && customizableSelections.Region != ERegion.US)
            {
                validationsErrors.Add("O Estado selecionado não pertence a/ao mesmo(a) Região/País selecionada(o) ou vice-versa.");
            }

            if (validationsErrors.Count > 0)
            { 
                _loggerService.SetLogContext("ErrorType", new { ValidationError = validationsErrors});
                _loggerService.SetLog(Serilog.Events.LogEventLevel.Warning, "Um Usuário inseriu dados inválidos e obteve StatusCode 400 (Bad Request) como response");
                var options = new JsonSerializerOptions { WriteIndented = true }; 
                return BadRequest(new { ValidationErrors = validationsErrors });
            }

            _loggerService.SetLog(Serilog.Events.LogEventLevel.Information, "A requisição foi validada, gerando dados...");

            List<PersonBase> persons = new List<PersonBase>();

            for (int i = 1; i <= customizableSelections.Quantity; i++)
            {
                try
                {
                    var personGenerator = _registerService.GetPersonGenerator(customizableSelections.Region);

                    var person = personGenerator.GeneratePerson(customizableSelections);

                    persons.Add(person);
                }
                catch (Exception ex)
                {
                    _loggerService.SetLogContext("ErrorType", ex.GetType());
                    _loggerService.SetLog(Serilog.Events.LogEventLevel.Warning, $"Usuário gerou uma exceção do tipo {ex.GetType()}");
                    return StatusCode(StatusCodes.Status500InternalServerError, $"Exceção gerada: {ex.GetType()} message :{ex.Message}");
                }
            }
            return StatusCode(StatusCodes.Status201Created, persons);
        }
    }
}
