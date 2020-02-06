using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using Ficcion.Comercial.Creditos.Dominio;


namespace Ficcion.Comercial.Creditos.Contrato
{
    [ServiceContract]
    public interface ICreditoService
    {
        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ListarCreditos", BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Credito> ListarCreditos();
        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method ="POST", UriTemplate = "/RegistrarCredito", BodyStyle =WebMessageBodyStyle.Bare)]
        Credito RegistrarCredito(Credito credito);
        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "PUT", UriTemplate = "/ActualizarCredito", BodyStyle = WebMessageBodyStyle.Bare)]
        Credito ActualizarCredito(Credito credito);
        [OperationContract]
        [WebInvoke(RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "DELETE", UriTemplate = "/EliminarCredito/{IdCredito}", BodyStyle = WebMessageBodyStyle.Bare)]
        bool EliminarCredito(string IdCredito);
    }
}