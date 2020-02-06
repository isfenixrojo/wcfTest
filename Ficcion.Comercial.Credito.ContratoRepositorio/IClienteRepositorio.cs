using Ficcion.Comercial.Creditos.Dominio;
using System.Collections.Generic;

namespace Ficcion.Comercial.Creditos.ContratoRepositorio
{
    public interface IClienteRepositorio
    {
        Cliente ObtenerCliente(string NumeroDocumento);
        IEnumerable<Cliente> ListarCliente();
    }
}
