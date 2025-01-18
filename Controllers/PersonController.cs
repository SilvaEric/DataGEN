using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace GeradorDadosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public ActionResult GenerateDataBySelections(CustomizableSelections customizableSelections)
        {
            if(customizableSelections == null || customizableSelections.Quantity <= 0)
                return BadRequest("As seleções personalizadas ou quantidade inválidas.");

            Dictionary<string, PersonDataBase> persons = new Dictionary<string, PersonDataBase>();

            for (int i = 1; i <= customizableSelections.Quantity; i++)
            {
                var personGenerator = CreatePersonGenerator(customizableSelections.Region);

                if (personGenerator == null)
                    return StatusCode(StatusCodes.Status501NotImplemented, "A região selecionada não é suportada");
                
                var person = personGenerator.GeneratePerson(customizableSelections);
                
                if (person == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro ao gerar dados");
                }

                persons.Add($"Person {i}", person);
            }

            return Ok(persons);
        }

        private PersonDataBase CreatePersonGenerator(ERegion region)
        {
            return region switch
            {
                ERegion.BR => new BRPersonData(),
                ERegion.US => new USPersonData(),
                ERegion.UK => new UKPersonData(),
                ERegion.AS => new ASPersonData(),
                _ => null
            };
        }
    }
}
