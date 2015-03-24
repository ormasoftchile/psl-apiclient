using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class RespuestaRegistrarTurno: RespuestaApi
    {
        public Guid Id { get; set; }
        /// <summary>
        /// Token - corresponde al token para la espera del paciente, creado en base a las reglas
        /// establecidas en la configuración del Turno.
        /// </summary>
        public string Token { get; set; }
    }
}
