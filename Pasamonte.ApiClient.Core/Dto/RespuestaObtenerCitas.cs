using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    #region RespuestaObtenerCitasDto
    /// <summary>
    /// RespuestaCitas - describe la respuesta a la consulta ObtenerCitas.
    /// </summary>
    public class RespuestaObtenerCitas: RespuestaApi
    {
        /// <summary>
        /// Citas - colección de las citas para el paciente.
        /// </summary>
        public IEnumerable<Cita> Citas { get; set; }
    }
    #endregion
}
