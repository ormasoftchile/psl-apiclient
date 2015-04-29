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
        /// ObtenerTerminales
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="query">Criterios de seleccion. <see cref="QueryObtenerTerminales"/></param>
        /// <returns>Objeto de respuesta. <see cref="RespuestaObtenerTerminales"/></returns>
        public RespuestaObtenerTerminales ObtenerTerminalesSync
            (
                string url,
                string apiKey,
                QueryObtenerTerminales query
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaObtenerTerminales>("ObtenerTerminales");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaObtenerTerminales>("ObtenerTerminales");
            var respuesta = new RespuestaObtenerTerminales()
            {

            };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP POST
                var requestData = JObject.FromObject(query);
                requestData["apiKey"] = apiKey;
                requestData["idNodo"] = "";
                requestData["titulo"] = "";

                try
                {
                    var response = 
                        client.PostAsJsonAsync
                        (
                            AccionObtenerTerminales,
                            requestData
                        ).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        // Get the URI of the created resource.
                        var r = response.Content.ReadAsStringAsync().Result;
                        respuesta =
                            response.Content.ReadAsAsync<RespuestaObtenerTerminales>().Result;
                    }
                    else
                    {
                        respuesta.Status = StatusLlamada.ErrorDesconocido;
                    }
                }
                catch(Exception ex)
                {
                    respuesta.Status = StatusLlamada.ErrorDesconocido;
                }
            }
            return respuesta;
        }
    }
}
