﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    #region RespuestaNotificarEntregaDto
    public class RespuestaNotificarEntrega: RespuestaApi
    {
        public DateTime? FechaProximaEntrega { get; set; }
    }
    #endregion
}
