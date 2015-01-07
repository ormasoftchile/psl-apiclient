using log4net;
using Pasamonte.ApiClient.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient
{
    /// <summary>
    /// ApiClient
    /// </summary>
    public partial class ApiClient: IApiClient
    {
        const string RceBaseAccion = "api/rce/";
        const string RceAccionAutenticar = RceBaseAccion + "autenticar";
        const string RceAccionObtenerEntregas = RceBaseAccion + "obtenerentregas";
        const string RceAccionNotificarEntrega = RceBaseAccion + "notificarentrega";
        const string AdmBaseAccion = "api/adm/";
        const string AdmAccionNotificar = AdmBaseAccion + "notificar";

        ILog log;

        public ApiClient(ILog log)
        {
            this.log = log;
        }


        public Task<Core.Dto.RespuestaObtenerCitas> RceObtenerCitas(string url, string apiKey, Core.Dto.IdentificacionUsuario identificacionUsuario, Core.Dto.IdentificacionTerminal identificacionTerminal, Core.Dto.IdentificacionSistemaRemoto identificacionSistemaRemoto)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Dto.RespuestaConfirmarCita> RceConfirmarCita(string url, string apiKey, Core.Dto.IdentificacionUsuario identificacionUsuario, Core.Dto.IdentificacionTerminal identificacionTerminal, Core.Dto.IdentificacionSistemaRemoto identificacionSistemaRemoto, Guid idCita)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Dto.RespuestaCancelarCita> RceCancelarCita(string url, string apiKey, Core.Dto.IdentificacionUsuario identificacionUsuario, Core.Dto.IdentificacionTerminal identificacionTerminal, Core.Dto.IdentificacionSistemaRemoto identificacionSistemaRemoto, Core.Dto.Cita cita)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Dto.RespuestaCambiarClave> RceCambiarClave(string url, string apiKey, Core.Dto.IdentificacionUsuario identificacionUsuario, Core.Dto.IdentificacionTerminal identificacionTerminal, Core.Dto.IdentificacionSistemaRemoto identificacionSistemaRemoto, string nuevaClave)
        {
            throw new NotImplementedException();
        }
    }
}
