﻿using System;
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
        #region RceAutenticar
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
        Task<RespuestaValidarIdentificacion> RceAutenticar
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto
            );
        #endregion
        #region RceObtenerEntregas
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
        Task<RespuestaObtenerEntregas> RceObtenerEntregas
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto
            );
        #endregion
        #region RceNotificarEntrega
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
        Task<RespuestaNotificarEntrega> RceNotificarEntrega
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto,
                Entrega entrega
            );
        #endregion
        #region RceObtenerCitas
        /// <summary>
        /// ObtenerCitas - obtiene las citas pendientes para un paciente o un nodo asociado
        /// a un terminal.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="identificacionUsuario">Identificación del usuario final.</param>
        /// <param name="identificacionTerminal">Identificación del terminal de acceso para el usuario.</param>
        /// <param name="identificacionSistemaRemoto">Identificación del sistema de registro clínico.</param>
        /// <returns>Objeto con datos de las citas <see cref="RespuestaObtenerCitas"/></returns>
        Task<RespuestaObtenerCitas> RceObtenerCitas
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto
            );
        #endregion
        #region RceConfirmarCita
        /// <summary>
        /// RceConfirmarCita - confirma la llegada a una cita de un paciente.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="identificacionUsuario">Identificación del usuario final.</param>
        /// <param name="identificacionTerminal">Identificación del terminal de acceso para el usuario.</param>
        /// <param name="identificacionSistemaRemoto">Identificación del sistema de registro clínico.</param>
        /// <param name="idCita">Id de la Cita</param>
        Task<RespuestaConfirmarCita> RceConfirmarCita
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto,
                string idCita
            );
        #endregion
        #region RceCancelarCita
        /// <summary>
        /// RceCancelarCita - Cancela una cita de un paciente.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="identificacionUsuario">Identificación del usuario final.</param>
        /// <param name="identificacionTerminal">Identificación del terminal de acceso para el usuario.</param>
        /// <param name="identificacionSistemaRemoto">Identificación del sistema de registro clínico.</param>
        /// <param name="idCita">Id de la Cita</param>
        Task<RespuestaCancelarCita> RceCancelarCita
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto,
                string idCita
            );
        #endregion
        #region RceCambiarClave
        /// <summary>
        /// CambiarClave - cambia la clave del usuario final en el sistema
        /// remoto.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="identificacionUsuario">Identificación del usuario final.</param>
        /// <param name="identificacionTerminal">Identificación del terminal de acceso para el usuario.</param>
        /// <param name="identificacionSistemaRemoto">Identificación del sistema de registro clínico.</param>
        /// <param name="nuevaClave">Nueva clave del usuario.</param>
        /// <returns>Objeto con datos de respuesta <see cref="RespuestaValidarIdentificacion"/></returns>
        Task<RespuestaCambiarClave> RceCambiarClave
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal,
                IdentificacionSistemaRemoto identificacionSistemaRemoto,
                string nuevaClave
            );
        #endregion
        #region AdmNotificar
        Task<RespuestaNotificar> Notificar
            (
                string url,
                string apiKey,
                Notificacion notificacion
            );
        #endregion
    }
}
