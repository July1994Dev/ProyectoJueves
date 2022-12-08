using System.Data;
using System.Text;

namespace Abonos.Models
{
    public class Abono
    {
        public int IdAbono { get; set; }
        public int IdCompra { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;


        //}
        //public Abono(IDataReader pReader)
        //{
        //    IdCompra = pReader.FInt("IdCompra");
        //    Precio = pReader.FDec("Precio");
        //    Saldo = pReader.FDec("Saldo");
        //    Descripcion = pReader.FStr("Descripcion");
        //    Estado = pReader.FStr("Estado");
        //}
    }
}
