using la_mia_pizzeria_static.Controllers.Repository;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiPizzaController : ControllerBase
    {
        public InerfacePizzaRepository _interface;

        public ApiPizzaController(InerfacePizzaRepository repo) : base()
        {
            _interface = repo;
        }

        public IActionResult Get()
        {

            List<Pizza> pizze = _interface.ListPizze();

            return Ok(pizze);
        }

        public IActionResult Showt(int id)
        {

            Pizza pizze = _interface.TihisPizza(id);

            return Ok(pizze);
        }

    }
}
