using Pasamonte.ApiClient.Core;
using Pasamonte.ApiClient.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient
{
    /// <summary>
    /// ApiClient
    /// </summary>
    public partial class ApiClient
    {
        public async Task<RespuestaNotificar> Notificar
            (
                string url,
                string apiKey,
                Notificacion notificacion
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaNotificar>("Notificar");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaNotificar>("Notificar");
            if (notificacion == null)
                return new RespuestaNotificar()
                {
                    Status = StatusLlamada.ErrorDesconocido,
                    Descripcion = "Error en Notificar. El objeto notificacion es nulo"
                };
            var respuesta = new RespuestaNotificar()
            {

            };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP POST
                var requestData = notificacion;
                    //new
                    //{
                    //    notificacion = notificacion
                    //};
                var response =
                    await client.PostAsJsonAsync
                    (
                        AdmAccionNotificar,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    respuesta = await response.Content.ReadAsAsync<RespuestaNotificar>();
                }
                else
                {
                    respuesta.Status = StatusLlamada.ErrorDesconocido;
                    respuesta.Descripcion = response.StatusCode.ToString();
                }
            }
            return respuesta;
        }
    }
}
