using Abonos.Models;
using Abonos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Abonos.Controllers
{
    public class PrincipalController : Controller
    {
        private readonly AbonoRepositorio AbonoRepositorio;
        public PrincipalController(AbonoRepositorio pAbonoRepositorio)
        {
            AbonoRepositorio = pAbonoRepositorio;
        }
        [HttpGet("GetHistorial")]
        public IActionResult GetHistorialAbonos(int pIdCompra)
        {
            try
            {
                List<Abono> historialAbonos = AbonoRepositorio.GetHistorialAbonos(pIdCompra);

                return Ok(historialAbonos);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPost("Abonar")]
        public IActionResult Abonar([FromBody] Abono pAbono)
        {
            AbonoRepositorio.Abonar(pAbono);

            return RedirectToRoute("/");
        }
    }
}
