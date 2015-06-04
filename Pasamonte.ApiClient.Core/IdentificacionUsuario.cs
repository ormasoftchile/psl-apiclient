using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core
{
    /// <summary>
    /// IdentificacionUsuario - datos de identificación de un usuario.
    /// </summary>
    public class IdentificacionUsuario
    {
        /// <summary>
        /// Tipo - tipo de identificación.
        /// </summary>
        public TipoIdentificacion Tipo { get; set; }
        /// <summary>
        /// Canal - canal utilizado por el usuario para identificarse
        /// </summary>
        public CanalIdentificacion Canal { get; set; }
        /// <summary>
        /// Identificador - RUN, usuario u otro.
        /// </summary>
        public string Identificador { get; set; }
        /// <summary>
        /// Clave - clave del usuario
        /// </summary>
        public string Clave { get; set; }
        /// <summary>
        /// Token - token de autenticacion obtenido en el sistema remoto. Utilizado para subsecuentes llamadas.
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// Reset - limpia la información dejándola en defaults.
        /// </summary>
        public void Reset()
        {
            Tipo = TipoIdentificacion.Ninguno;
            Canal = CanalIdentificacion.Ninguno;
            Identificador = null;
            Clave = null;
        }
    }
}
