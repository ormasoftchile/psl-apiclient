using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class Servicio
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
        #region Activo
        /// <summary>
        /// Activo
        /// </summary>
        public bool activo { get; set; }
        #endregion
        #region Bloqueado
        /// <summary>
        /// Bloqueado
        /// </summary>
        public bool bloqueado { get; set; }
        #endregion
        #region IdNodo
        /// <summary>
        /// Identificador del nodo donde está instalado
        /// </summary>
        public Guid? idNodo { get; set; }
        #endregion
        #region Nodo
        /// <summary>
        /// Nodo
        /// </summary>
        public Nodo nodo { get; set; }
        #endregion
        #region ConfiguracionJson
        public string configuracionJson { get; set; }
        #endregion
        #region TipoDeToken
        public TipoDeTokenServicio tipoDeToken { get; set; }
        #endregion
        #region TokenMaximoCorrelativo
        public int tokenMaximoCorrelativo { get; set; }
        #endregion
        #region UltimoTokenGenerado
        public string ultimoTokenGenerado { get; set; }
        #endregion
        #region PrioridadVisual
        public PrioridadVisualServicio prioridadVisual { get; set; }
        #endregion
    }

    public enum TipoDeTokenServicio
    {
        Numerico = 0,
        Alfanumerico = 1,
        CodigoQR = 2
    }

    public enum PrioridadVisualServicio
    {
        Baja = 0,
        Normal = 1,
        Alta = 2
    }
}
