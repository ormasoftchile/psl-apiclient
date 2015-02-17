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
        /// RegistrarTurno
        /// </summary>
        /// <param name="url"></param>
        /// <param name="apiKey"></param>
        /// <param name="turno">Turno a registrar</param>
        /// <returns></returns>
        public async Task<RespuestaRegistrarTurno> RegistrarTurno
            (
                string url,
                string apiKey,
                Turno turno
            )
        {
            var respuesta = new RespuestaRegistrarTurno()
            {

            };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var requestData = JObject.FromObject(turno);
                requestData["apiKey"] = apiKey;

                // HTTP POST
                var response =
                    await client.PostAsJsonAsync
                    (
                        AccionRegistrarTurno,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsAsync<RespuestaRegistrarTurno>();
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
