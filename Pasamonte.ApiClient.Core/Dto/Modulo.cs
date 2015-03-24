using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class Modulo
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
        #region IdServicio
        public Guid? idServicio { get; set; }
        #endregion
        #region IdTurno
        public Guid? idTurno { get; set; }
        #endregion
    }
}
