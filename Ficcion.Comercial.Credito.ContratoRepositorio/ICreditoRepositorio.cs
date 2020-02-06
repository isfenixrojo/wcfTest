using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ficcion.Comercial.Creditos.Dominio;

namespace Ficcion.Comercial.Creditos.ContratoRepositorio
{
    public interface ICreditoRepositorio
    {
        IEnumerable<Credito> ListarCreditos();
        Credito RegistrarCredito(Credito credito);
        Credito ActualizarCredito(Credito credito);
        bool EliminarCredito(string IdCredito);
    }
}
