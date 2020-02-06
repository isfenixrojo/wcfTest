using Ficcion.Comercial.Creditos.Contrato;
using Ficcion.Comercial.Creditos.Dominio;
using Ficcion.Comercial.Creditos.Fachada;
using System.Collections.Generic;


namespace Ficcion.Comercial.Creditos.Implementacion
{
    public class ClienteService : IClienteService
    {

        public Cliente ObtenerCliente(string NumeroDocumento)
        {
            using ( var conexion = new ClienteFachada())
            {
                return conexion.ObtenerCliente(NumeroDocumento);
            }
        }

        public IEnumerable<Cliente> ListarCliente()
        {
            using (var conexion = new ClienteFachada()) {
                return conexion.ListarCliente();
            }
        }
    }
}
