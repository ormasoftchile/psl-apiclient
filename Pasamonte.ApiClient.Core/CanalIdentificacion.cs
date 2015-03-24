
namespace Pasamonte.ApiClient.Core
{
    /// <summary>
    /// TipoIdentificacion - tipos posibles de canales de identificacion
    /// </summary>
    public enum CanalIdentificacion
    {
        /// <summary>
        /// Ninguno - no especificado
        /// </summary>
        Ninguno = 0,
        /// <summary>
        /// Teclado - nombre de usuario(login)
        /// </summary>
        Teclado = 1,
        /// <summary>
        /// Cedula - cédula de identidad
        /// </summary>
        Cedula = 2,
        /// <summary>
        /// TarjetaMagnetica - tarjeta de identificación
        /// </summary>
        TarjetaMagnetica = 3,
        /// <summary>
        /// TarjetaContactless - tarjeta contactless
        /// </summary>
        TarjetaContactless = 4
    }
}
