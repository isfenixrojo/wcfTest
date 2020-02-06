using Ficcion.Comercial.Creditos.Contrato;
using Ficcion.Comercial.Creditos.Dominio;
using Ficcion.Comercial.Creditos.Fachada;
using System.Collections.Generic;

namespace Ficcion.Comercial.Creditos.Implementacion
{
    public class CreditoService : ICreditoService
    {
        public Credito ActualizarCredito(Credito credito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.ActualizarCredito(credito);
            }
        }

        public bool EliminarCredito(string IdCredito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.EliminarCredito(IdCredito);
            }
        }

        public IEnumerable<Credito> ListarCreditos()
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.ListarCreditos();
            }
        }

        public Credito RegistrarCredito(Credito credito)
        {
            using (var instancia = new CreditoFachada())
            {
                return instancia.RegistrarCredito(credito);
            }
        }
    }
}
