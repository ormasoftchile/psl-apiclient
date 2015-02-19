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
        /// RegistrarServicio
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="servicio">Servicio a registrar</param>
        /// <returns>Objeto con respuesta. <see cref="RespuestaRegistrarServicio"/></returns>
        public async Task<RespuestaRegistrarServicio> RegistrarServicio
            (
                string url,
                string apiKey,
                Servicio servicio
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaRegistrarServicio>("RegistrarServicio");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaRegistrarServicio>("RegistrarServicio");
            if (servicio == null)
                return new RespuestaRegistrarServicio()
                {
                    Status = StatusLlamada.ErrorDesconocido,
                    Descripcion = "RegistrarServicio - Error parametro servicio nulo"
                };
            var respuesta = new RespuestaRegistrarServicio()
            {

            };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var requestData = JObject.FromObject(servicio);
                requestData["apiKey"] = apiKey;

                // HTTP POST
                var response =
                    await client.PostAsJsonAsync
                    (
                        AccionRegistrarServicio,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsAsync<RespuestaRegistrarServicio>();
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
