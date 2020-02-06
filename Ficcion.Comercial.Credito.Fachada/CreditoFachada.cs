using System;
using System.Collections.Generic;
using Ficcion.Comercial.Creditos.Dominio;
using Ficcion.Comercial.Creditos.ContratoRepositorio;
using Ficcion.Comercial.Creditos.SQLRepository;

namespace Ficcion.Comercial.Creditos.Fachada
{
    public class CreditoFachada : IDisposable
    {
        public IEnumerable<Credito> ListarCreditos()
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.ListarCreditos();
        }
        public Credito RegistrarCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.RegistrarCredito(credito);
        }
        public Credito ActualizarCredito(Credito credito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.ActualizarCredito(credito);
        }
        public bool EliminarCredito(string IdCredito)
        {
            ICreditoRepositorio instancia = new CreditoRepositorio();
            return instancia.EliminarCredito(IdCredito);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
