using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeradorDadosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostSelections(CustomizableSelections customizableSelections)
        {
            return Ok(customizableSelections);
        }
    }
}
