using la_mia_pizzeria_static.Controllers.Repository;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        [HttpPost]
        public IActionResult Create(Message message)
        {
            try
            {
                _interface.AddMessages(message);
            }catch ( Exception ex)
            {
                return UnprocessableEntity(ex);
            }

            List<Message> messages = _interface.ListMessage();

            return Ok(messages);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Message message)
        {
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }

            if (_interface.ThisMessage(id) != null)
            {
                // ... aggiorniamo il nostro dato a DB
                _interface.UpdateMessage(id, message);
                List<Message> messages = _interface.ListMessage();

                return Ok(messages);
            }
            else
            {
                // se non è stato trovato resituiamo che non esiste
                return NotFound();
            }

        }
    }
}
