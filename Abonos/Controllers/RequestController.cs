using Microsoft.AspNetCore.Mvc;

namespace Abonos.Controllers
{
    public class RequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
