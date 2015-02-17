using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class Turno
    {
        #region Id
        /// <summary>
        /// Post identity
        /// </summary>
        public Guid? id { get; set; }
        #endregion

        #region Token
        public string token { get; set; }
        #endregion

        #region IdServicio
        public Guid idServicio { get; set; }
        #endregion
        #region IdNodo
        /// <summary>
        /// Identificador del nodo donde está instalado
        /// </summary>
        public Guid? idNodo { get; set; }
        #endregion
        #region HoraEstimadaAtencion
        public DateTime? horaEstimadaAtencion { get; set; }
        #endregion
        #region Estado
        public EstadoTurno estado { get; set; }
        #endregion
        #region IdModulo
        public Guid? idModulo { get; set; }
        #endregion
    }

    public enum EstadoTurno
    {
        NoDefinido = 0,
        Activo = 1,
        Atendido = 2,
        Cancelado = 3
    }
}
