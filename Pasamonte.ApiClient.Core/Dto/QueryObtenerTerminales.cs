using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class QueryObtenerTerminales
    {
        #region Id
        /// <summary>
        /// Post identity
        /// </summary>
        public Guid? id { get; set; }
        #endregion
        #region Titulo
        public string titulo { get; set; }
        #endregion
        #region IdNodo
        public Guid? idNodo { get; set; }
        #endregion
    }
}
