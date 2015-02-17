using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class Cita
    {
        #region Id
        /// <summary>
        /// Post identity
        /// </summary>
        public Guid? id { get; set; }
        #endregion
        #region SistemaDeOrigenId
        /// <summary>
        /// SistemaDeOrigenId - id asignado al sistema remoto.
        /// </summary>
        /// <remarks>Es asignado por PSL en convenio con el party remoto.</remarks>
        public Guid sistemaDeOrigenId { get; set; }
        #endregion
        #region IdEnSistemaDeOrigen
        /// <summary>
        /// IdEnSistemaDeOrigen - Id en el sistema remoto.
        /// </summary>
        /// Las citas son recibidas desde un sistema externo.
        /// Este id representa la identificacion unica de la cita en el sistema externo.
        public string idEnSistemaDeOrigen { get; set; }
        #endregion
        #region Estado
        public EstadoCita estado { get; set; }
        #endregion
        #region Persona
        /// <summary>
        /// Datos de la persona participante de la cita
        /// </summary>
        public Persona persona { get; set; }
        #endregion
        #region Propiedad FechaHoraInicio
        /// <summary>
        /// FechaHoraInicio del Cita
        /// </summary>
        public DateTime? fechaHoraInicio { get; set; }
        #endregion
        #region Propiedad FechaHoraLlegada
        /// <summary>
        /// FechaHoraLlegada del Cita
        /// </summary>
        public DateTime? fechaHoraLlegada { get; set; }
        #endregion
        #region Propiedad FechaHoraTermino
        /// <summary>
        /// FechaHoraTermino del Cita
        /// </summary>
        public DateTime? fechaHoraTermino { get; set; }
        #endregion
        #region Propiedad FechaHoraAsignacion
        /// <summary>
        /// FechaHoraAsignacion del Cita
        /// </summary>
        public DateTime? fechaHoraAsignacion { get; set; }
        #endregion
        #region Propiedad MedioDeReserva
        /// <summary>
        /// MedioDeReserva del Cita
        /// </summary>
        //[DataMember]
        public MedioDeReservaCita medioDeReserva { get; set; }
        #endregion
        #region DescripcionMedioDeReserva
        public string descripcionMedioDeReserva { get; set; }
        #endregion
        #region Propiedad EsGrupal
        /// <summary>
        /// EsGrupal del Cita
        /// </summary>
        public bool esGrupal { get; set; }
        #endregion
        #region Propiedad Observacion
        public string observacion { get; set; }
        #endregion
        #region Propiedad TipoDeAtencion
        /// <summary>
        /// Id de razon de la cita
        /// </summary>
        public TipoDeAtencionCita tipoDeAtencion { get; set; }
        #endregion
        #region Propiedad DescripcionTipoDeAtencion
        public string descripcionTipoDeAtencion { get; set; }
        #endregion
        #region Propiedad Instrumento
        /// <summary>
        /// IdDeInstrumento del Cita
        /// </summary>
        public string instrumento { get; set; }
        #endregion
        #region Propiedad CodigoEstablecimiento
        public string codigoEstablecimiento { get; set; }
        #endregion
        #region Propiedad NodoId
        /// <summary>
        /// IdNodo del Cita
        /// </summary>
        public Guid nodoId { get; set; }
        #endregion
        #region Nodo
        /// <summary>
        /// Related Object
        /// </summary>
        public Nodo nodo { get; set; }
        #endregion
        #region LugarDeAtencion
        public string lugarDeAtencion { get; set; }
        #endregion
        #region TokenDeLlamada
        public string tokenDeLlamada { get; set; }
        #endregion
        #region IdentificadorProfesional
        public string identificadorProfesional { get; set; }
        #endregion
        #region NombresProfesional
        /// <summary>
        /// NombresProfesional - nombres del profesional.
        /// </summary>
        public string nombresProfesional { get; set; }
        #endregion
        #region PrimerApellidoProfesional
        /// <summary>
        /// PrimerApellidoProfesional - apellido paterno del profesional.
        /// </summary>
        public string primerApellidoProfesional { get; set; }
        #endregion
        #region SegundoApellidoProfesional
        /// <summary>
        /// SegundoApellidoProfesional - apellido materno del profesional.
        /// </summary>
        public string segundoApellidoProfesional { get; set; }
        #endregion
        #region TelefonoMovilProfesional
        public string telefonoMovilProfesional { get; set; }
        #endregion
        #region EmailProfesional
        public string emailProfesional { get; set; }
        #endregion
        #region sector
        public string sector { get; set; }
        #endregion
    }

    public enum EstadoCita
    {
        Pendiente = 0,
        Confirmada = 1,
        PacienteSePresento = 2,
        Cancelada = 3,
        Completada = 4
    }

    public enum ProcedenciaCita
    {
        SinEspecificar = 0
    }

    public enum MedioDeReservaCita
    {
        SinEspecificar = 0
    }

    public enum TipoDeAtencionCita
    {
        SinEspecificar = 0,
        Otro = 100
    }
}
