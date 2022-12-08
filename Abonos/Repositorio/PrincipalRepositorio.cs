using System.Data;
using Abonos.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Abonos.Repositorio
{
    public class PrincipalRepositorio
    {
        private readonly SqlConnection SqlServer;

        public PrincipalRepositorio(IConfiguration pConfiguration)
        {
            SqlServer = new SqlConnection(pConfiguration.GetConnectionString("Compras"));
        }

        public List<Principal> GetAllComprasPendientes()
        {
            if (SqlServer.State == ConnectionState.Closed)
            {
                SqlServer.Open();
            }

            return SqlServer.Query<Principal>("dbo.pGetComprasPendientes", commandType: CommandType.StoredProcedure).ToList();

        }
        public Principal GetCompra(int pIdCompra)
        {
            if (SqlServer.State == ConnectionState.Closed)
            {
                SqlServer.Open();
            }
            var parametros = new { IdCompra = pIdCompra };
            return SqlServer.QuerySingle<Principal>("dbo.pGetCompra", parametros, commandType: CommandType.StoredProcedure);
        }
    }
}
