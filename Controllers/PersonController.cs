using GeradorDadosAPI.Enums;
using GeradorDadosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace GeradorDadosAPI.Controllers
{
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public Task<ActionResult<PersonDataBase>> PostSelections(ERegion region, List<string> selections, int quantity)
        {
            var _customizableSelections = new CustomizableSelections(region, selections, quantity);


        }
    }
}
