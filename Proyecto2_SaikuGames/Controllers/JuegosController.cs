using Microsoft.AspNetCore.Mvc;

namespace Proyecto2_SaikuGames.Controllers
{
    public class JuegosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
