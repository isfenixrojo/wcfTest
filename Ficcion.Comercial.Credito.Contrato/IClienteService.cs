using Ficcion.Comercial.Creditos.Dominio;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Ficcion.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/obtenerCliente/{NumeroDocumento}", BodyStyle =WebMessageBodyStyle.Bare)]
        Cliente ObtenerCliente(string NumeroDocumento);
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/listarCliente", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Cliente> ListarCliente();
    }
}
