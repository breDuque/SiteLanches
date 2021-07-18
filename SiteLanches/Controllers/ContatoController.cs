using Microsoft.AspNetCore.Mvc;

namespace SiteLanches.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}