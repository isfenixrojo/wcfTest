using Ficcion.Comercial.Creditos.Dominio;
using Ficcion.Comercial.Creditos.SQLRepository;
using Ficcion.Comercial.Creditos.ContratoRepositorio;
using System;
using System.Collections.Generic;
namespace Ficcion.Comercial.Creditos.Fachada
{
    public class ClienteFachada : IDisposable
    {
        public Cliente ObtenerCliente(string NumeroDocumento)
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.ObtenerCliente(NumeroDocumento);
        }

        public IEnumerable<Cliente> ListarCliente()
        {
            IClienteRepositorio instancia = new ClienteRepositorio();
            return instancia.ListarCliente();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

