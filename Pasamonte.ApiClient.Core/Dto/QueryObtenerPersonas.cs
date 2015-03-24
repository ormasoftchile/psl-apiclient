using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class QueryObtenerPersonas
    {
        public Guid? id { get; set; }
        public string identificadorEnSistemaRemoto { get; set; }
        public TipoIdentificacionPaciente[] tipoIdentificacion { get; set; }
        public string nombres { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
    }
}
