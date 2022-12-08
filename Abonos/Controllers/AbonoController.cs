
using Abonos.Models;
using Abonos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Abonos.Controllers
{
    public class AbonoController : Controller
    {
        private readonly PrincipalRepositorio PrincipalRepositorio;
        private readonly AbonoRepositorio AbonoRepositorio;

        public AbonoController(PrincipalRepositorio pPrincipalRepositorio, AbonoRepositorio abonoRepositorio)
        {
            PrincipalRepositorio = pPrincipalRepositorio;
            AbonoRepositorio = abonoRepositorio;
        }

        public IActionResult Registrar(int id)
        {
            Principal compra = PrincipalRepositorio.GetCompra(id);
            return View(compra);
        }

        public IActionResult Historial(int id)
        {
            List<Abono> historialAbonos = AbonoRepositorio.GetHistorialAbonos(id);
            return View(historialAbonos);
        }

        public IActionResult Abonar([FromForm] Abono pAbono)
        {
            AbonoRepositorio.Abonar(pAbono);

            return RedirectToRoute("/");
        }

    }
}
