using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class IdentificacionTerminal
    {
        #region Codigo
        /// <summary>
        /// Codigo - Código del terminal
        /// </summary>
        /// Corresponde a código configurado para cada terminal  en su archivo de configuración.
        public string Codigo { get; set; }
        #endregion

        /// <summary>
        /// CodigoEstablecimiento - código del establecimiento en el que se ubica físicamente el equipo desde el
        /// cual el paciente está accediendo a los servicios.
        /// </summary>
        public string CodigoEstablecimiento { get; set; }
    }
}
