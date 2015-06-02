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
    public class Paciente
    {
        public string IdentificadorPaciente { get; set; }
        public string Nombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Sexo { get; set; }
        public string FechaNacimiento { get; set; }
        public string Identificador { get; set; }
        public string Descripcion { get; set; }
        public string Alerta { get; set; }
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
