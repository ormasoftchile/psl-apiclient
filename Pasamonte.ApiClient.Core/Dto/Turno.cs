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
        #region Columna1
        public string columna1 { get; set; }
        #endregion
        #region Columna2
        public string columna2 { get; set; }
        #endregion
        #region Columna3
        public string columna3 { get; set; }
        #endregion
        #region Columna4
        public string columna4 { get; set; }
        #endregion
    }

    public enum EstadoTurno
    {
        /// <summary>
        /// Estado inicial del turno. Se utiliza durante la creacion del turno.
        /// </summary>
        NoDefinido = 0,
        /// <summary>
        /// Activo - paciente se encuentra esperando el turno de atencion
        /// </summary>
        Activo = 1,
        /// <summary>
        /// Atendido - paciente ya fue convocado al modulo de atencion.
        /// </summary>
        Atendido = 2,
        /// <summary>
        /// Cancelado - turno cancelado.
        /// </summary>
        Cancelado = 3
    }
}
