using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    #region RespuestaObtenerEntregasDto
    /// <summary>
    /// RespuestaEntregas - describe la respuesta a la consulta ObtenerEntregas.
    /// </summary>
    public class RespuestaObtenerEntregas
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
        /// Paciente - datos del paciente.
        /// </summary>
        public Persona Persona { get; set; }
        /// <summary>
        /// Entregas - colección de las entregas (recetas) pendientes para el paciente.
        /// </summary>
        public IEnumerable<Entrega> Entregas { get; set; }
    }
    #endregion
}
