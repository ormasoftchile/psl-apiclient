﻿using System;
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
        /// RceConfirmarCita
        /// </summary>
        /// <param name="url">Url del servicio Pasamonte</param>
        /// <param name="apiKey">Clave de integracion</param>
        /// <param name="idCita">identificador de la cita</param>
        /// <returns>Objeto con respuesta. <see cref="RespuestaConfirmarCita"/></returns>
        public async Task<RespuestaConfirmarCita> RceConfirmarCita
            (
                string url,
                string apiKey,
                string idCita
            )
        {
            if (!ValidarUrl(url))
                return RespuestaErrorUrl<RespuestaConfirmarCita>("RceConfirmarCita");
            if (!ValidarApiKey(apiKey))
                return RespuestaErrorApiKey<RespuestaConfirmarCita>("RceConfirmarCita");
            if (string.IsNullOrWhiteSpace(idCita))
                return new RespuestaConfirmarCita()
                {
                    Status = StatusLlamada.ErrorDesconocido,
                    Descripcion = "RceConfirmarCita - Error parametro idCita vacio"
                };
            var respuesta = new RespuestaConfirmarCita()
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
                        idCita = idCita
                    };
                var response =
                    await client.PostAsJsonAsync
                    (
                        RceAccionConfirmarCita,
                        requestData
                    );
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsAsync<RespuestaConfirmarCita>();
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
