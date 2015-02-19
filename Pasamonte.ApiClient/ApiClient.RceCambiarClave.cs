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
        /// RceCambiarClave
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="identificacionUsuario"></param>
        /// <param name="identificacionTerminal"></param>
        /// <param name="identificacionSistemaRemoto"></param>
        /// <param name="nuevaClave"></param>
        /// <returns>Objeto con la respuesta</returns>
        public async Task<RespuestaCambiarClave> RceCambiarClave
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal, 
                IdentificacionSistemaRemoto identificacionSistemaRemoto,
                string nuevaClave
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaCambiarClave>("RceCambiarClave");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaCambiarClave>("RceCambiarClave");
            var respuesta = new RespuestaCambiarClave()
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
                        identificacionUsuario = identificacionUsuario,
                        identificacionTerminal = identificacionTerminal,
                        identificacionSistemaRemoto = identificacionSistemaRemoto,
                        nuevaClave = nuevaClave
                    };
                var response =
                    await client.PostAsJsonAsync
                    (
                        RceAccionCambiarClave,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsAsync<RespuestaCambiarClave>();
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
