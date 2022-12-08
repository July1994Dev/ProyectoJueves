using System.Data;
using Abonos.Models;
using Dapper;
using Microsoft.Data.SqlClient;


namespace Abonos.Repositorio
{
    public class AbonoRepositorio
    {
        private readonly SqlConnection SqlServer;

        public AbonoRepositorio(IConfiguration pConfiguration)
        {
            SqlServer = new SqlConnection(pConfiguration.GetConnectionString("Compras"));
        }

        public void Abonar(Abono pAbono)
        {
            if (SqlServer.State == ConnectionState.Closed)
            {
                SqlServer.Open();
            }
            var parametros = new { IdCompra = pAbono.IdCompra, Monto = pAbono.Monto };
            SqlServer.Execute("dbo.pGuardarAbono", parametros, commandType: CommandType.StoredProcedure);

        }
        public List<Abono> GetHistorialAbonos(int pIdCompra)
        {
            if (SqlServer.State == ConnectionState.Closed)
            {
                SqlServer.Open();
            }
            var parametros = new { IdCompra = pIdCompra };
            return SqlServer.Query<Abono>("[dbo].[pGetHistorialAbonos]", parametros, commandType: CommandType.StoredProcedure).ToList();
        }
    }
}
