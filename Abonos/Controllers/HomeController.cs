using Microsoft.AspNetCore.Mvc;

namespace Abonos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
