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
        /// NotificarEntrega
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="identificacionUsuario"></param>
        /// <param name="identificacionTerminal"></param>
        /// <param name="identificacionSistemaRemoto"></param>
        /// <param name="entrega">Entrega a notificar</param>
        /// <returns>Objeto con la respuesta. <see cref="RespuestaNotificarEntrega"/></returns>
        public async Task<RespuestaNotificarEntrega> RceNotificarEntrega
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal, 
                IdentificacionSistemaRemoto identificacionSistemaRemoto,
                Entrega entrega
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaNotificarEntrega>("RceNotificarEntrega");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaNotificarEntrega>("RceNotificarEntrega");
            if (entrega == null)
                return new RespuestaNotificarEntrega()
                {
                    Status = StatusLlamada.ErrorDesconocido,
                    Descripcion = "RceNotificarEntrega - Error parametro entrega nulo"
                };
            var respuesta = new RespuestaNotificarEntrega()
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
                        entrega = entrega
                    };
                var response =
                    await client.PostAsJsonAsync
                    (
                        RceAccionNotificarEntrega,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsAsync<RespuestaNotificarEntrega>();
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
