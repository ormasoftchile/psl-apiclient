﻿using System;
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
        /// ObtenerModulos
        /// </summary>
        /// <param name="url"></param>
        /// <param name="apiKey"></param>
        /// <param name="query"></param>
        /// <returns>Objeto de respuesta</returns>
        public async Task<RespuestaObtenerModulos> ObtenerModulos
            (
                string url,
                string apiKey,
                QueryObtenerModulos query
            )
        {
            var respuesta = new RespuestaObtenerModulos()
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
                        AccionObtenerModulos,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    var r = await response.Content.ReadAsStringAsync();
                    respuesta =
                        await response.Content.ReadAsAsync<RespuestaObtenerModulos>();
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