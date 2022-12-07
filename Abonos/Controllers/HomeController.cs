using Microsoft.AspNetCore.Mvc;

namespace Abonos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Abono(int id)
        {

            return View(id);
        }
    }
}
