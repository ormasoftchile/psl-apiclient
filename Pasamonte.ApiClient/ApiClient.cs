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
        const string RceAccionCambiarClave = RceBaseAccion + "cambiarclave";
        const string RceAccionCancelarCita = RceBaseAccion + "cancelarcita";
        const string RceAccionConfirmarCita = RceBaseAccion + "confirmarcita";
        const string RceAccionObtenerCitas = RceBaseAccion + "obtenercitas";
        const string AdmBaseAccion = "api/adm/";
        const string AdmAccionNotificar = AdmBaseAccion + "notificar";

        ILog log;

        public ApiClient(ILog log)
        {
            this.log = log;
        }
    }
}
