﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pasamonte.ApiClient.Core;
using Pasamonte.ApiClient.Core.Dto;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace Pasamonte.ApiClient
{
    public partial class ApiClient
    {
        /// <summary>
        /// Autenticar
        /// </summary>
        /// <param name="url"></param>
        /// <param name="apiKey"></param>
        /// <param name="identificacionUsuario"></param>
        /// <param name="identificacionTerminal"></param>
        /// <param name="identificacionSistemaRemoto"></param>
        /// <returns></returns>
        public async Task<RespuestaValidarIdentificacion> RceAutenticar
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto
            )
        {
            var respuesta = new RespuestaValidarIdentificacion()
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
                        RceAccionAutenticar,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    respuesta = await response.Content.ReadAsAsync<RespuestaValidarIdentificacion>();
                    log.DebugFormat("-> RceAutenticar: ok. Terminal: {0}. Usuario: {1}", identificacionTerminal.CodigoEstablecimiento, identificacionUsuario.Identificador);
                }
                else
                {
                    respuesta.Status = StatusLlamada.ErrorDesconocido;
                    log.DebugFormat("-> RceAutenticar: ERROR. Terminal: {0}. Usuario: {1}", identificacionTerminal.CodigoEstablecimiento, identificacionUsuario.Identificador);
                }
            }
            return respuesta;
        }
    }
}
