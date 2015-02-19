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
        /// EliminarModulo
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="idModulo">Identificador del modulo.</param>
        /// <returns>Objeto con la respuesta. <see cref="RespuestaEliminarModulo"/></returns>
        public async Task<RespuestaEliminarModulo> EliminarModulo
            (
                string url,
                string apiKey,
                Guid idModulo
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaEliminarModulo>("EliminarModulo");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaEliminarModulo>("EliminarModulo");
            if (idModulo == Guid.Empty)
                return new RespuestaEliminarModulo()
                {
                    Status = StatusLlamada.ErrorDesconocido,
                    Descripcion = "Eliminar modulo. Error idModulo esta vacio"
                };
            var respuesta = new RespuestaEliminarModulo()
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
                        idModulo = idModulo
                    };
                var response =
                    await client.PostAsJsonAsync
                    (
                        AccionEliminarModulo,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsAsync<RespuestaEliminarModulo>();
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
