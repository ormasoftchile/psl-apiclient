using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pasamonte.ApiClient.Core.Dto;

namespace Pasamonte.ApiClient.Core
{
    /// <summary>
    /// ApiClient - define las operaciones que se pueden realizar como
    /// cliente de la api de integración de Pasamonte.
    /// </summary>
    /// Toda llamada debe incorporar la url de destino del server Pasamonte
    /// a utilizar y la clave de integración (apiKey).
    public interface IApiClient
    {
        /// <summary>
        /// Autenticar - valida la identidad del usuario final en el sistema
        /// remoto.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="identificacionUsuario">Identificación del usuario final.</param>
        /// <param name="identificacionTerminal">Identificación del terminal de acceso para el usuario.</param>
        /// <param name="identificacionSistemaRemoto">Identificación del sistema de registro clínico.</param>
        /// <returns>Objeto con datos de respuesta <see cref="RespuestaValidarIdentificacion"/></returns>
        Task<RespuestaValidarIdentificacion> Autenticar
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto
            );
        /// <summary>
        /// ObtenerEntregas - obtiene las entregas pendientes de medicamentos para
        /// un paciente.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="identificacionUsuario">Identificación del usuario final.</param>
        /// <param name="identificacionTerminal">Identificación del terminal de acceso para el usuario.</param>
        /// <param name="identificacionSistemaRemoto">Identificación del sistema de registro clínico.</param>
        /// <returns>Objeto con datos de las entregas <see cref="RespuestaObtenerEntregas"/></returns>
        Task<RespuestaObtenerEntregas> ObtenerEntregas
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto
            );
        /// <summary>
        /// NotificarEntrega - notifica al sistema remoto sobre la ocurrencia
        /// de una entrega de medicamentos a un usuario final.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="identificacionUsuario">Identificación del usuario final.</param>
        /// <param name="identificacionTerminal">Identificación del terminal de acceso para el usuario.</param>
        /// <param name="identificacionSistemaRemoto">Identificación del sistema de registro clínico.</param>
        /// <param name="entrega">Objeto que describe la entrega realizada <see cref="Entrega"/></param>
        /// <returns>Objeto con status de la operación <see cref="RespuestaNotificarEntrega"/></returns>
        Task<RespuestaNotificarEntrega> NotificarEntrega
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto,
                Entrega entrega
            );
    }
}
