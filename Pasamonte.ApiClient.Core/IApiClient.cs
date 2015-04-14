using System;
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
        #region acceso
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
        #endregion
        #region entregas
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
        #endregion
        #region citas
        #region RceRegistrarCita
        /// <summary>
        /// RceRegistrarCita - registra una cita de un paciente.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="cita">Cita</param>
        Task<RespuestaRegistrarCita> RceRegistrarCita
            (
                string url,
                string apiKey,
                Cita cita
            );
        #endregion
        #region RceConfirmarCita
        /// <summary>
        /// RceConfirmarCita - confirma la llegada a una cita de un paciente.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="idCita">Id de la Cita</param>
        Task<RespuestaConfirmarCita> RceConfirmarCita
            (
                string url,
                string apiKey,
                string idCita
            );
        #endregion
        #region RceCancelarCita
        /// <summary>
        /// RceCancelarCita - Cancela una cita de un paciente.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="idCita">Id de la Cita</param>
        Task<RespuestaCancelarCita> RceCancelarCita
            (
                string url,
                string apiKey,
                string idCita
            );
        #endregion
        #region RceObtenerCitas
        /// <summary>
        /// ObtenerCitas - obtiene las citas pendientes para un paciente o un nodo asociado
        /// a un terminal.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="query">Query con criterios de seleccion de citas</param>
        /// <returns>Objeto con datos de las citas <see cref="RespuestaObtenerCitas"/></returns>
        Task<RespuestaObtenerCitas> RceObtenerCitas
            (
                string url,
                string apiKey,
                QueryObtenerCitas query
            );
        #endregion
        #endregion
        #region servicios
        #region RegistrarServicio
        /// <summary>
        /// RegistrarServicio - registra un servicio de atención.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="servicio">Id del servicio</param>
        Task<RespuestaRegistrarServicio> RegistrarServicio
            (
                string url,
                string apiKey,
                Servicio servicio
            );
        #endregion
        #region EliminarServicio
        /// <summary>
        /// EliminarServicio - Elimina un servicio de atención.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="idServicio">Id del servicio</param>
        Task<RespuestaEliminarServicio> EliminarServicio
            (
                string url,
                string apiKey,
                Guid idServicio
            );
        #endregion
        #region ObtenerServicios
        /// <summary>
        /// ObtenerServicios - obtiene los servicios de atención de acuerdo a los criterios de filtro.
        /// a un terminal.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="query">Query con criterios de seleccion de servicios</param>
        /// <returns>Objeto con datos de los servicios <see cref="RespuestaObtenerServicios"/></returns>
        Task<RespuestaObtenerServicios> ObtenerServicios
            (
                string url,
                string apiKey,
                QueryObtenerServicios query
            );
        #endregion
        #endregion
        #region modulos
        #region RegistrarModulo
        /// <summary>
        /// RegistrarModulo - registra un módulo de atención.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="modulo">Id del módulo</param>
        Task<RespuestaRegistrarModulo> RegistrarModulo
            (
                string url,
                string apiKey,
                Modulo modulo
            );
        #endregion
        #region EliminarModulo
        /// <summary>
        /// EliminarModulo - elimina un módulo de atención.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="idModulo">Id del módulo</param>
        Task<RespuestaEliminarModulo> EliminarModulo
            (
                string url,
                string apiKey,
                Guid idModulo
            );
        #endregion
        #region ObtenerModulos
        /// <summary>
        /// ObtenerModulos - obtiene los módulos de atención de acuerdo a criterios de filtro.
        /// a un terminal.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="query">Query con criterios de seleccion de módulos</param>
        /// <returns>Objeto con datos de los módulos<see cref="RespuestaObtenerModulos"/></returns>
        Task<RespuestaObtenerModulos> ObtenerModulos
            (
                string url,
                string apiKey,
                QueryObtenerModulos query
            );
        #endregion
        #endregion
        #region turnos
        #region RegistrarTurno
        /// <summary>
        /// RegistrarTurno - registra una turno de atención.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="turno">Id del turno creado.</param>
        Task<RespuestaRegistrarTurno> RegistrarTurno
            (
                string url,
                string apiKey,
                Turno turno
            );
        #endregion
        #region EliminarTurno
        /// <summary>
        /// EliminarTurno - elimina un turno de atención.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="idTurno">Id del turno.</param>
        Task<RespuestaEliminarTurno> EliminarTurno
            (
                string url,
                string apiKey,
                Guid idTurno
            );
        #endregion
        #region ObtenerTurnos
        /// <summary>
        /// ObtenerTurnos - obtiene los turnos de acuerdo a criterios de filtro.
        /// a un terminal.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="query">Query con criterios de seleccion de los turnos</param>
        /// <returns>Objeto con datos de los turnos.<see cref="RespuestaObtenerTurnos"/></returns>
        Task<RespuestaObtenerTurnos> ObtenerTurnos
            (
                string url,
                string apiKey,
                QueryObtenerTurnos query
            );
        #endregion
        #endregion
        #region ObtenerTerminales
        /// <summary>
        /// ObtenerTerminales - obtiene los terminales de acuerdo al criterio de filtro.
        /// a un terminal.
        /// </summary>
        /// <param name="url">Url del servidor Pasamonte.</param>
        /// <param name="apiKey">Clave de integración.</param>
        /// <param name="query">Query con criterios de seleccion de terminales</param>
        /// <returns>Objeto con datos de los terminales <see cref="RespuestaObtenerTerminales"/></returns>
        Task<RespuestaObtenerTerminales> ObtenerTerminales
            (
                string url,
                string apiKey,
                QueryObtenerTerminales query
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
