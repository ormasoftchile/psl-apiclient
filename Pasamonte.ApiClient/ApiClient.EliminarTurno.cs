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
        /// EliminarTurno
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="idTurno">Identificador del turno</param>
        /// <returns>Objeto con respuesta. <see cref="RespuestaEliminarTurno"/></returns>
        public async Task<RespuestaEliminarTurno> EliminarTurno
            (
                string url,
                string apiKey,
                Guid idTurno
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaEliminarTurno>("EliminarTurno");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaEliminarTurno>("EliminarTurno");
            if (idTurno == Guid.Empty)
                return new RespuestaEliminarTurno()
                {
                    Status = StatusLlamada.ErrorDesconocido,
                    Descripcion = "EliminarTurno - Error parametro idTurno vacio"
                };
            var respuesta = new RespuestaEliminarTurno()
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
                        idTurno = idTurno
                    };
                var response =
                    await client.PostAsJsonAsync
                    (
                        AccionEliminarTurno,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsAsync<RespuestaEliminarTurno>();
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
