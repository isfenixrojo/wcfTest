using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficcion.Comercial.Creditos.SQLRepository
{
    public class ConexionRepositorio
    {
        public static string ConnexionString()
        {
            return ConfigurationManager.ConnectionStrings["CreditosDB"].ToString();
        }
    }
}
