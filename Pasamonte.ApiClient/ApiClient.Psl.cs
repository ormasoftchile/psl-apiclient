using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pasamonte.ApiClient.Core;
using Pasamonte.ApiClient.Core.Dto;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Pasamonte.ApiClient.Domain;

namespace Pasamonte.ApiClient
{
    public partial class ApiClient
    {
        #region PslGetClientes
        /// <summary>
        /// PslGetClientes
        /// </summary>
        /// <param name="url"></param>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        public async Task<RespuestaApi<IEnumerable<Cliente>>> PslGetClientes
            (
                string url,
                string apiKey,
                string query = null
            )
        {
            return await PslGet<IEnumerable<Cliente>>(url, apiKey, PslAccionGetClientes, query);
        }
        #endregion
        #region PslGetNodos
        /// <summary>
        /// PslGetNodos
        /// </summary>
        /// <param name="url"></param>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        public async Task<RespuestaApi<IEnumerable<Nodo>>> PslGetNodos
            (
                string url,
                string apiKey,
                string query = null
            )
        {
            return await PslGet<IEnumerable<Nodo>>(url, apiKey, PslAccionGetNodos, query);
        }
        #endregion
    }
}
