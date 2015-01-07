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
    public class RespuestaObtenerCitas
    {
        /// <summary>
        /// CodigoRespuesta - status de la llamada
        /// </summary>
        public StatusLlamada Status { get; set; }
        /// <summary>
        /// Descripcion - glosa descriptiva del status de la llamada.
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Entregas - colección de las entregas (recetas) pendientes para el paciente.
        /// </summary>
        public IEnumerable<Cita> Citas { get; set; }
    }
    #endregion
}
