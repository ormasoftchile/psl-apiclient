using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core
{
    /// <summary>
    /// IdentificacionSistemaRemoto - Identifica un sistema remoto por sus atributos de empresa, software y versión.
    /// </summary>
    public class IdentificacionSistemaRemoto
    {
        #region Codigo
        /// <summary>
        /// Codigo - codigo identificador único del sistema de RCE.
        /// Está compuesto de la siguiente manera:
        /// xxxxxxxx.yyyyyy.[z]
        /// -------- ------ ---
        ///     |        |    |
        ///     |        |    |
        /// Identificador \    \
        /// de la empresa  \    \
        /// Ej. Saydex      \    ------------- Versión del software. Ej. 1.0.0.1a
        ///                 Identificador del software. Ej. Rayen
        /// </summary>
        public string Codigo { get; set; }
        #endregion
        #region Empresa
        public string Empresa
        {
            get
            {
                if (string.IsNullOrEmpty(Codigo) || string.IsNullOrWhiteSpace(Codigo))
                    return string.Empty;
                var partes = Codigo.Split('.');
                if (partes.Length == 0)
                    return string.Empty;
                return partes[0];
            }
        }
        #endregion
        #region Software
        public string Software
        {
            get
            {
                if (string.IsNullOrEmpty(Codigo) || string.IsNullOrWhiteSpace(Codigo))
                    return string.Empty;
                var partes = Codigo.Split('.');
                if (partes.Length < 2)
                    return string.Empty;
                return partes[1];
            }
        }
        #endregion
        #region Version
        public string Version
        {
            get
            {
                if (string.IsNullOrEmpty(Codigo) || string.IsNullOrWhiteSpace(Codigo))
                    return string.Empty;
                var partes = Codigo.Split('.');
                if (partes.Length < 3)
                    return string.Empty;
                var b = new StringBuilder();
                b.Append(partes[2]);
                for (var i = 3; i < partes.Length; i++)
                    b.AppendFormat(".{0}", partes[i]);
                return b.ToString();
            }
        }
        #endregion
    }
}
