using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using GeradorDadosAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

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
            if(customizableSelections.SelectedDatas?.Any() != true || customizableSelections.Quantity <= 0 || customizableSelections.Age.HasValue && customizableSelections.Age <=0)
                return BadRequest("As seleções são inválidas. para que a entrada de dados seja válida voce deve selecionar ao menos um tipo de dado, uma quantidade ou idade maior que 0");

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

                case ERegion.UK:
                    return new UKPersonData(_registerService);

                case ERegion.AS:
                    return new ASPersonData(_registerService);

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
