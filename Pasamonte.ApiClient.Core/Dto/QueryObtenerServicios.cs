using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class QueryObtenerServicios
    {
        public Guid? id { get; set; }
        public string titulo { get; set; }
        public bool? activo { get; set; }
        public bool? bloqueado { get; set; }
        public Guid? idNodo { get; set; }
        public TipoDeTokenServicio[] tipoDeToken { get; set; }
        public PrioridadVisualServicio[] prioridadVisual { get; set; }
    }
}
