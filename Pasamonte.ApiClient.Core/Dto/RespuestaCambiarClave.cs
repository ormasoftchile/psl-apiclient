using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    #region RespuestaCambiarClave
    /// <summary>
    /// RespuestaCambiarClave - describe la respuesta a la consulta CambiarClave.
    /// </summary>
    public class RespuestaCambiarClave
    {
        /// <summary>
        /// CodigoRespuesta - status de la llamada
        /// </summary>
        public StatusLlamada Status { get; set; }
        /// <summary>
        /// Descripcion - glosa descriptiva del status de la llamada.
        /// </summary>
        public string Descripcion { get; set; }
    }
    #endregion
}
