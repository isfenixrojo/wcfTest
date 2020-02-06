using Ficcion.Comercial.Creditos.Dominio;
using Ficcion.Comercial.Creditos.ContratoRepositorio;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Ficcion.Comercial.Creditos.SQLRepository
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        public Cliente ObtenerCliente(string NumeroDocumento)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ConnexionString()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("NumeroDocumento", NumeroDocumento);

                var cliente = conexion.QuerySingle<Cliente>("dbo.SP_GetClienteByNumeroDocumento",
                    param: parametros,
                    commandType: CommandType.StoredProcedure);

                return cliente;
            }
        }
        public IEnumerable<Cliente> ListarCliente()
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ConnexionString()))
            {
                conexion.Open();
                var cliente = conexion.Query<Cliente>("dbo.SP_GetAllCliente",
                    commandType: CommandType.StoredProcedure);
                return cliente;

            }
        }
    }
}
