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
        /// RegistrarModulo
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="modulo">Modulo a registrar</param>
        /// <returns>Objeto con respuesta. <see cref="RespuestaRegistrarModulo"/></returns>
        public async Task<RespuestaRegistrarModulo> RegistrarModulo
            (
                string url,
                string apiKey,
                Modulo modulo
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaRegistrarModulo>("RegistrarModulo");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaRegistrarModulo>("RegistrarModulo");
            if (modulo == null)
                return new RespuestaRegistrarModulo()
                {
                    Status = StatusLlamada.ErrorDesconocido,
                    Descripcion = "RegistrarModulo - Error parametro modulo nulo"
                };
            var respuesta = new RespuestaRegistrarModulo()
            {

            };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var requestData = JObject.FromObject(modulo);
                requestData["apiKey"] = apiKey;

                // HTTP POST
                var response =
                    await client.PostAsJsonAsync
                    (
                        AccionRegistrarModulo,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsAsync<RespuestaRegistrarModulo>();
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
