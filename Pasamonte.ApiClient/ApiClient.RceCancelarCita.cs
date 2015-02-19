using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pasamonte.ApiClient.Core.Dto;
using System.Net.Http;
using System.Net.Http.Headers;
using Pasamonte.ApiClient.Core;

namespace Pasamonte.ApiClient
{
    public partial class ApiClient
    {
        /// <summary>
        /// RceCancelarCita
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="idCita">Identificador de la cita</param>
        /// <returns>Objeto con respuesta. <see cref="RespuestaCancelarCita"/></returns>
        public async Task<RespuestaCancelarCita> RceCancelarCita
            (
                string url,
                string apiKey,
                string idCita
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaCancelarCita>("RceCancelarCita");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaCancelarCita>("RceCancelarCita");
            if (string.IsNullOrWhiteSpace(idCita))
                return new RespuestaCancelarCita()
                {
                    Status = StatusLlamada.ErrorDesconocido,
                    Descripcion = "RceCancelarCita - Error parametro idCita vacio"
                };
            var respuesta = new RespuestaCancelarCita()
            {

            };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP POST
                var requestData =
                    new
                    {
                        apiKey = apiKey,
                        idCita = idCita
                    };
                var response =
                    await client.PostAsJsonAsync
                    (
                        RceAccionCancelarCita,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsAsync<RespuestaCancelarCita>();
                }
                else
                {
                    respuesta.Status = StatusLlamada.ErrorDesconocido;
                }
            }
            return respuesta;
        }
    }
}
