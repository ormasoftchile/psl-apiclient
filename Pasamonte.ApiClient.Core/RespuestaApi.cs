using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core
{
    public class RespuestaApi<T>
    {
        public T Contenido { get; private set; }
        public StatusLlamada Status { get; private set; }
        public RespuestaApi(StatusLlamada status, T contenido = default(T))
        {
            Status = status;
            Contenido = contenido;
        }
    }
}
