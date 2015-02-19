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
        /// ObtenerServicios
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="query">Criterios de seleccion. <see cref="QueryObtenerServicio"/></param>
        /// <returns>Objeto de respuesta. <see cref="RespuestaObtenerServicio"/></returns>
        public async Task<RespuestaObtenerServicios> ObtenerServicios
            (
                string url,
                string apiKey,
                QueryObtenerServicios query
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaObtenerServicios>("ObtenerServicios");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaObtenerServicios>("ObtenerServicios");
            var respuesta = new RespuestaObtenerServicios()
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
                var response =
                    await client.PostAsJsonAsync
                    (
                        AccionObtenerServicios,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    var r = await response.Content.ReadAsStringAsync();
                    respuesta =
                        await response.Content.ReadAsAsync<RespuestaObtenerServicios>();
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
