using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class TypePacienteLight
    {
        public int? IdentificadorPaciente { get; set; }
        public string Nombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int Sexo { get; set; }
        public string FechaNacimiento { get; set; }
        public string Descripcion { get; set; }
        public string Alerta { get; set; }
    }
}
