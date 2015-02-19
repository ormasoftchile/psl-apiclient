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
        /// EliminarServicio
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="idServicio">Identificador del servicio</param>
        /// <returns>Objeto con respuesta. <see cref="RespuestaEliminarServicio"/></returns>
        public async Task<RespuestaEliminarServicio> EliminarServicio
            (
                string url,
                string apiKey,
                Guid idServicio
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaEliminarServicio>("EliminarServicio");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaEliminarServicio>("EliminarServicio");
            if (idServicio == Guid.Empty)
                return new RespuestaEliminarServicio()
                {
                    Status = StatusLlamada.ErrorDesconocido,
                    Descripcion = "EliminarServicio - Error parametro idServicio vacio"
                };
            var respuesta = new RespuestaEliminarServicio()
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
                        idServicio = idServicio
                    };
                var response =
                    await client.PostAsJsonAsync
                    (
                        AccionEliminarServicio,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsAsync<RespuestaEliminarServicio>();
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
