using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class Notificacion
    {
        public Guid Id { get; set; }

        public TipoNotificacion Tipo { get; set; }

        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

        public string Datos { get; set; }

        public Guid IdTerminal { get; set; }
    }
}
