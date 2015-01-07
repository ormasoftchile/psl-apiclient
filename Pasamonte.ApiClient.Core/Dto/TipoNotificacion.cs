using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public enum TipoNotificacion
    {
        Ninguno,
        Temperatura,
        EstadoOperativo,
        EstadoTerminal,
        SyncTerminal,
        SyncStock,
        Entrega
    }
}
