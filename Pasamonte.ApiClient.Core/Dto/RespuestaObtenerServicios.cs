using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class RespuestaObtenerServicios: RespuestaApi
    {
        public IEnumerable<Servicio> Servicios { get; set; }
    }
}
