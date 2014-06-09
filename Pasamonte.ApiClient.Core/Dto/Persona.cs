using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    /// <summary>
    /// Representa un nodo de la red
    /// </summary>
    public class Persona
    {
        /// <summary>
        /// Post identity
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// IdentificadorPaciente - string identificador del paciente (cedula o pasaporte).
        /// </summary>
        public string IdentificadorPaciente { get; set; }

        /// <summary>
        /// TipoIdentificacionPaciente - define el tipo de identificación del paciente (RUN, RUN responsable o pasaporte).
        /// </summary>
        public TipoIdentificacionPaciente TipoIdentificacionPaciente { get; set; }

        /// <summary>
        /// Nombres - nombres del paciente.
        /// </summary>
        public string Nombres { get; set; }

        /// <summary>
        /// PrimerApellido - apellido paterno del paciente.
        /// </summary>
        public string PrimerApellido { get; set; }

        /// <summary>
        /// SegundoApellido - apellido materno del paciente.
        /// </summary>
        public string SegundoApellido { get; set; }

        public string TelefonoResidencial { get; set; }

        public string TelefonoMovil { get; set; }

        public string Email { get; set; }
    }

    #region TipoIdentificacionPaciente
    /// <summary>
    /// TipoIdentificacionPaciente
    /// </summary>
    /// Especifica cómo se identifica a un paciente, ya sea con su RUN, el RUN de la persona responsable o bien
    /// con el número de pasaporte.
    public enum TipoIdentificacionPaciente
    {
        Run = 1,
        RunResponsable = 2,
        Pasaporte = 3
    }
    #endregion
}
