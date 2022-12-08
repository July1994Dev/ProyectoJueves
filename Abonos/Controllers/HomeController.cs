using Abonos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Abonos.Controllers
{
    public class HomeController : Controller
    {
        private readonly AbonoRepositorio AbonoRepositorio;
        private readonly PrincipalRepositorio PrincipalRepositorio;
        public HomeController(AbonoRepositorio pAbonoRepositorio, PrincipalRepositorio pPrincipalRepositorio)
        {
            AbonoRepositorio = pAbonoRepositorio;
            PrincipalRepositorio = pPrincipalRepositorio;
        }

        public IActionResult Index()
        {
            var model = PrincipalRepositorio.GetAllComprasPendientes();
            return View(model);
        }
    }
}
