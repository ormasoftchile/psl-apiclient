using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class Terminal
    {
        #region Id
        /// <summary>
        /// Post identity
        /// </summary>
        public Guid? id { get; set; }
        #endregion

        /// <summary>
        /// Identificador del tipo de terminal
        /// </summary>
        public Guid idTipoTerminal { get; set; }

        #region Titulo
        public string titulo { get; set; }
        #endregion

        /// <summary>
        /// Descripcion for this article
        /// </summary>
        public string descripcion { get; set; }

        public string codigoFabricante { get; set; }

        public string modelo { get; set; }

        public Guid? idNodo { get; set; }

        public Nodo nodo { get; set; }

        public Guid idStatusAdministrativo { get; set; }

        public Guid idStatusOperativo { get; set; }

        public string ubicacionGeografica { get; set; }

        public string versionSoftwareOperativo { get; set; }

        public Guid? idCliente { get; set; }

        public string configuracion { get; set; }

        public bool usarHardware { get; set; }

        public bool desconectado { get; set; }

        public bool usarCamara { get; set; }

        public bool despachoParcial { get; set; }

        public bool mostrarReceta { get; set; }

        public bool entregaExacta { get; set; }

        public string filtroTipoRecetas { get; set; }

        public string estado { get; set; }

        public string identificadorEnRCE { get; set; }
    }
}
