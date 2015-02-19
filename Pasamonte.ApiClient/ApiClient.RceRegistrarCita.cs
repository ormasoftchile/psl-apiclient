using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pasamonte.ApiClient.Core.Dto;
using System.Net.Http;
using System.Net.Http.Headers;
using Pasamonte.ApiClient.Core;
using Newtonsoft.Json.Linq;

namespace Pasamonte.ApiClient
{
    public partial class ApiClient
    {
        /// <summary>
        /// RegistrarCita
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="cita">Cita a registrar</param>
        /// <returns>Objeto con respuesta. <see cref="RespuestaRegistrarCita"/></returns>
        public async Task<RespuestaRegistrarCita> RceRegistrarCita
            (
                string url,
                string apiKey,
                Cita cita
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaRegistrarCita>("RceRegistrarCita");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaRegistrarCita>("RceRegistrarCita");
            if (cita == null)
                return new RespuestaRegistrarCita()
                {
                    Status = StatusLlamada.ErrorDesconocido,
                    Descripcion = "RceRegistrarCita - Error parametro cita nulo"
                };
            var respuesta = new RespuestaRegistrarCita()
            {

            };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var requestData = JObject.FromObject(cita);
                requestData["apiKey"] = apiKey;

                // HTTP POST
                var response =
                    await client.PostAsJsonAsync
                    (
                        RceAccionRegistrarCita,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsAsync<RespuestaRegistrarCita>();
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
