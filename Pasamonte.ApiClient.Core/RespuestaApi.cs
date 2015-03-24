
namespace Pasamonte.ApiClient.Core
{
    public class RespuestaApi
    {
        /// <summary>
        /// CodigoRespuesta - status de la llamada
        /// </summary>
        public StatusLlamada Status { get; set; }
        /// <summary>
        /// Descripcion - glosa descriptiva del status de la llamada.
        /// </summary>
        public string Descripcion { get; set; }
        public RespuestaApi(StatusLlamada status, string descripcion = null)
        {
            Status = status;
            Descripcion = descripcion;
        }
        public RespuestaApi()
        {

        }
    }
}
