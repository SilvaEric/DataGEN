using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using GeradorDadosAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GeradorDadosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IRegisterService _registerService;
            
        public PersonController(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        [HttpPost]
        public ActionResult GenerateDataBySelections(CustomizableSelections customizableSelections)
        {
            string invalidSelections = "Seleção inválida.";
            if (!customizableSelections.SelectedDatas.Any())
                return BadRequest($"{invalidSelections} Para que a entrada de dados seja válida o parametro SelectedDatas deve conter ao menos um tipo de dado para ser retornado!");

            if (customizableSelections.Quantity <= 0)
                return BadRequest($"{invalidSelections} O parametro Quantity deve ser > 0.");

            if(customizableSelections.Age.HasValue && customizableSelections.Age <= 0)
                return BadRequest($"{invalidSelections} Quando informado o parametro Age deve ser > 0.");

            if (customizableSelections.StatesBR.HasValue && customizableSelections.Region != ERegion.BR || customizableSelections.StatesUS.HasValue && customizableSelections.Region != ERegion.US)
            {
                return BadRequest($"{invalidSelections} O Estado selecionado não pertence a mesmo(a) Região/País selecionado(a).");
            }

            List<PersonBase> persons = new List<PersonBase>();

            for (int i = 1; i <= customizableSelections.Quantity; i++)
            {
                try
                {
                    var personGenerator = CreatePersonGenerator(customizableSelections.Region);

                    var person = personGenerator.GeneratePerson(customizableSelections);

                    if (person == null)
                    {
                        return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao gerar dados");
                    }

                    persons.Add(person);
                }
                catch (NotImplementedException)
                {
                    return StatusCode(StatusCodes.Status501NotImplemented, "A região selecionada não é suportada");
                }
            }
            return Ok(persons);
        }

        private PersonBase CreatePersonGenerator(ERegion region)
        {
            switch (region)
            {
                case ERegion.BR:
                    return new BRPersonData(_registerService);

                case ERegion.US:
                    return new USPersonData(_registerService);

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
