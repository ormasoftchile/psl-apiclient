﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    #region RespuestaCancelarCita
    /// <summary>
    /// RespuestaCancelarCita - describe la respuesta a la consulta CancelarCita.
    /// </summary>
    public class RespuestaCancelarCita
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
