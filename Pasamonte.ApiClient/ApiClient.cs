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
        const string RceAccionCancelarCita = AdmBaseAccion + "cancelarcita";
        const string RceAccionConfirmarCita = AdmBaseAccion + "confirmarcita";
        const string RceAccionRegistrarCita = AdmBaseAccion + "registrarcita";
        const string RceAccionObtenerCitas = AdmBaseAccion + "obtenercitas";
        const string AdmBaseAccion = "api/adm/";
        const string AdmAccionNotificar = AdmBaseAccion + "notificar";
        const string AccionEliminarModulo = AdmBaseAccion + "eliminarmodulo";
        const string AccionEliminarServicio = AdmBaseAccion + "eliminarservicio";
        const string AccionEliminarTurno = AdmBaseAccion + "eliminarturno";
        const string AccionRegistrarModulo = AdmBaseAccion + "registrarmodulo";
        const string AccionRegistrarServicio = AdmBaseAccion + "registrarservicio";
        const string AccionRegistrarTurno = AdmBaseAccion + "registrarturno";
        const string AccionObtenerModulos = AdmBaseAccion + "obtenermodulos";
        const string AccionObtenerServicios = AdmBaseAccion + "obtenerservicios";
        const string AccionObtenerTurnos = AdmBaseAccion + "obtenerturnos";

        ILog log;

        public ApiClient(ILog log)
        {
            this.log = log;
        }

        protected bool ValidarApiKey(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                return false;
            return true;
        }

        protected T RespuestaErrorApiKey<T>(string metodo) where T: RespuestaApi, new()
        {
            var respuesta = new T();
            respuesta.Status = StatusLlamada.ErrorDesconocido;
            respuesta.Descripcion = string.Format("Error en metodo {0}. ApiKey erroneo", metodo);
            return respuesta;
        }

        protected bool ValidarUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return false;
            return true;
        }

        protected T RespuestaErrorUrl<T>(string metodo) where T : RespuestaApi, new()
        {
            var respuesta = new T();
            respuesta.Status = StatusLlamada.ErrorDesconocido;
            respuesta.Descripcion = string.Format("Error en metodo {0}. Url erronea", metodo);
            return respuesta;
        }
    }
}
