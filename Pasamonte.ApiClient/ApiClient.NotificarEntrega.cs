using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pasamonte.ApiClient.Core.Dto;

namespace Pasamonte.ApiClient
{
    public partial class ApiClient
    {
        public async Task<RespuestaNotificarEntrega> NotificarEntrega
            (
                string url,
                string apiKey,
                IdentificacionUsuario identificacionUsuario,
                IdentificacionTerminal identificacionTerminal, 
                IdentificacionSistemaRemoto identificacionSistemaRemoto,
                Entrega entrega
            )
        {
            throw new NotImplementedException();
        }
    }
}
