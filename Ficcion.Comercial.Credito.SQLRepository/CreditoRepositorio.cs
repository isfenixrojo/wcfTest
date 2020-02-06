using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ficcion.Comercial.Creditos.ContratoRepositorio;
using Ficcion.Comercial.Creditos.Dominio;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace Ficcion.Comercial.Creditos.SQLRepository
{
    public class CreditoRepositorio : ICreditoRepositorio
    {
        public Credito ActualizarCredito(Credito credito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ConnexionString()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("IdCredito", credito.IdCredito);
                parametros.Add("TipoCredito", credito.TipoCredito);
                parametros.Add("IdCliente", credito.IdCliente);
                parametros.Add("Fecha", credito.Fecha);
                parametros.Add("Monto", credito.Monto);
                parametros.Add("DiaPago", credito.DiaPago);
                parametros.Add("Tasa", credito.Tasa);
                parametros.Add("Comision", credito.Comision);


                var result = conexion.Execute("SP_UpdateCreditoByIdCredito", param: parametros, commandType: CommandType.StoredProcedure);
                return result > 0 ? credito : new Credito();
            }
        }

        public bool EliminarCredito(string IdCredito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ConnexionString()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("IdCredito", IdCredito);
                var result = conexion.Execute("SP_DeleteCreditoByIdCredito", param: parametros, commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public IEnumerable<Credito> ListarCreditos()
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ConnexionString()))
            {
                conexion.Open();
                var coleccion = conexion.Query<Credito>("SP_GetAllCredito", commandType: CommandType.StoredProcedure);
                return coleccion;
            }
        }

        public Credito RegistrarCredito(Credito credito)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.ConnexionString()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("TipoCredito", credito.TipoCredito);
                parametros.Add("IdCliente", credito.IdCliente);
                parametros.Add("Fecha", credito.Fecha);
                parametros.Add("Monto", credito.Monto);
                parametros.Add("DiaPago", credito.DiaPago);
                parametros.Add("Tasa", credito.Tasa);
                parametros.Add("Comision", credito.Comision);
                parametros.Add("IdCredito", credito.IdCredito, DbType.Int32, ParameterDirection.Output);

                var result = conexion.ExecuteScalar("SP_InsertCredito", param: parametros, commandType: CommandType.StoredProcedure);
                var pIdCredito = parametros.Get<Int32>("IdCredito");
                credito.IdCredito = pIdCredito;
                return credito;
            }
        }
    }
}
