using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core
{
    /// <summary>
    /// TipoIdentificacion - tipos posibles de medios de identificacion
    /// </summary>
    public enum TipoIdentificacion
    {
        /// <summary>
        /// Ninguno - no especificado
        /// </summary>
        Ninguno = 0,
        /// <summary>
        /// Usuario - nombre de usuario(login)
        /// </summary>
        Usuario = 1,
        /// <summary>
        /// Cedula - cédula de identidad
        /// </summary>
        Cedula = 2,
        /// <summary>
        /// Codigo - codigo propietario tarjeta de identificación
        /// </summary>
        Codigo = 3
    }
}
