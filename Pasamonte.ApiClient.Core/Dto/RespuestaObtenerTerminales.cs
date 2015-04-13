using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class RespuestaObtenerTerminales: RespuestaApi
    {
        public IEnumerable<Terminal> Terminales { get; set; }
    }
}
