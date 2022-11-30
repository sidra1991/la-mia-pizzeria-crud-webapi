using la_mia_pizzeria_static.Controllers.Repository;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.message
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ApiMessageController : ControllerBase
    {
        public InerfacePizzaRepository _interface;

        public ApiMessageController(InerfacePizzaRepository repo) : base()
        {
            _interface = repo;
        }

        public IActionResult Get()
        {

            List<Message> messages = _interface.ListMessage();

            return Ok(messages);
        }
    }
}
