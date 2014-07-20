using Pasamonte.ApiClient.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
        const string PslBaseAccion = "breeze/breezeapi/";
        const string PslAccionGetClientes = PslBaseAccion + "clientes";
        const string PslAccionGetNodos = PslBaseAccion + "nodos";

        async Task<RespuestaApi<T>> PslGet<T>(
            string url,
            string apiKey,
            string accion,
            string query)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var request = accion;
                if (!string.IsNullOrWhiteSpace(query))
                    request = request + "?" + query;
                // HTTP GET
                // *** Importante ***
                // La llamada asincrona se completa con .Result. Si se hace con "await", falla
                // en Xamarin y no encontre documentacion para resolver.
                var response =
                    client.GetAsync(request)
                    .Result;
                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    var contenido = await response.Content.ReadAsAsync<T>();
                    return new RespuestaApi<T>(StatusLlamada.Ok, contenido);
                }
                else
                {
                    return new RespuestaApi<T>(StatusLlamada.ErrorDesconocido);
                }
            }
        }
    }
}
