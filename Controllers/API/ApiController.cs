using la_mia_pizzeria_static.Controllers.Repository;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        public InerfacePizzaRepository _interface;

        public ApiController(InerfacePizzaRepository repo) : base()
        {
            _interface = repo;
        }

        public IActionResult Get()
        {

            List<Pizza> pizze = _interface.ListPizze();

            return Ok("prova se funziona");
        }

    }
}
