using System.Data;

namespace Abonos.Models
{
    public class Principal
    {

        public int IdCompra { get; set; }
        public decimal Precio { get; set; }
        public decimal Saldo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        //public Principal(IDataReader pReader)
        //{
        //    IdCompra = pReader.FInt("IdCompra");
        //    Monto = pReader.FDec("Monto");
        //    Fecha = pReader.FDate("Fecha");
        //}
    }
}
