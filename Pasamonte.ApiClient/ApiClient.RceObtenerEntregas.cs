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
        /// ObtenerEntregas
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="identificacionUsuario">Identificacion del paciente</param>
        /// <param name="identificacionTerminal">Identificacion del terminal que consulta</param>
        /// <param name="identificacionSistemaRemoto">Identificacion del sistema remoto (RCE)</param>
        /// <returns>Objeto con respuesta. <see cref="RespuestaObtenerEntregas"/></returns>
        public async Task<RespuestaObtenerEntregas> RceObtenerEntregas
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaObtenerEntregas>("RceObtenerEntregas");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaObtenerEntregas>("RceObtenerEntregas");
            var respuesta = new RespuestaObtenerEntregas()
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
                        identificacionSistemaRemoto = identificacionSistemaRemoto
                    };
                var response =
                    await client.PostAsJsonAsync
                    (
                        RceAccionObtenerEntregas,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    var r = await response.Content.ReadAsStringAsync();
                    respuesta =
                        await response.Content.ReadAsAsync<RespuestaObtenerEntregas>();
                    var b = new StringBuilder();
                    if (respuesta.Entregas != null)
                        foreach (var entrega in respuesta.Entregas)
                        {
                            b.AppendFormat("-- entrega id: {0} tipo: {1}\r\n", entrega.IdEnSistemaExterno, entrega.TipoEntrega);
                            if (entrega.ItemsEntrega != null)
                                foreach (var item in entrega.ItemsEntrega)
                                {
                                    b.AppendFormat("---- item id:\t{0}\tcantidad:\t{1}\tproducto:\t{2} desc:\t{3} stock rce:\t{4}\r\n", item.IdEnSistemaExterno, item.CantidadEntregar, item.IdentificadorProducto, item.DescripcionProducto, item.StockRCE);
                                }
                        }
                    log.DebugFormat("-> RceObtenerEntregas: ok. Terminal: {0}. Usuario: {1}\r\n{2}", identificacionTerminal.CodigoEstablecimiento, identificacionUsuario.Identificador, b.ToString());
                }
                else
                {
                    respuesta.Status = StatusLlamada.ErrorDesconocido;
                    log.DebugFormat("-> RceObtenerEntregas: ERROR. Terminal: {0}. Usuario: {1}", identificacionTerminal.CodigoEstablecimiento, identificacionUsuario.Identificador);
                }
            }
            return respuesta;
        }
    }
}
