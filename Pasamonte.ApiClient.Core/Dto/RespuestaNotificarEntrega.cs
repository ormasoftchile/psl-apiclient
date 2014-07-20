using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    #region RespuestaNotificarEntregaDto
    public class RespuestaNotificarEntrega
    {
        public StatusLlamada Status { get; set; }
        public string Descripcion { get; set; }
        public string FechaProximaEntrega { get; set; }
    }
    #endregion
}
