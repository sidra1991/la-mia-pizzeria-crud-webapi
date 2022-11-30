using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.message
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
