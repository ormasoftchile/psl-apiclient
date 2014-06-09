using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core
{
    #region StatusLlamada
    /// <summary>
    /// StatusLlamada - códigos de resultado de operaciones de integración.
    /// </summary>
    public enum StatusLlamada
    {
        /// <summary>
        /// Ok - llamada exitosa
        /// </summary>
        Ok = 0,
        /// <summary>
        /// ErrorDesconocido - ha ocurrido un error de causa desconocida que ha impedido ejecutar la operación.
        /// </summary>
        /// <remarks>Ha ocurrido un error de causa desconocida que ha impedido ejecutar la operación.</remarks>
        ErrorDesconocido = 1,
        /// <summary>
        /// UsuarioNoAutorizado - las credenciales provistas no non válidas en el sistema remoto.
        /// </summary>
        UsuarioNoAutorizado = 50,
        /// <summary>
        /// El código del establecimiento no está presente en la base de datos de Pasamonte.
        /// </summary>
        NoExisteCodigoEstablecimiento = 101,
        /// <summary>
        /// El código de la empresa no ha sido registrado en la base de datos de Pasamonte.
        /// </summary>
        NoExisteIdSitioInforma = 102,
        /// <summary>
        /// El código del software no ha sido registrado en la base de datos de Pasamonte.
        /// </summary>
        NoExisteIdSoftwareInforma = 103,
        /// <summary>
        /// FechaHoraMensajeNoValida - la fecha - hora del mensaje no es válida (formato).
        /// </summary>
        FechaHoraNoValida = 110,
        /// <summary>
        /// FechaHoraMensajeFuturo - la fecha - hora del mensaje está en el futuro. (error)
        /// </summary>
        FechaHoraFuturo = 111,
        /// <summary>
        /// La entrega referenciada no se encuentra.
        /// </summary>
        NoExisteEntrega = 200,
        /// <summary>
        /// Se solicita consultar sobre un establecimiento que no posee terminales de dispensación.
        /// </summary>
        EstablecimientoSinTerminales = 201,
        /// <summary>
        /// NoExisteCodigoTerminal - el codigo de terminal especificado no existe.
        /// </summary>
        NoExisteCodigoTerminal = 202,
        /// <summary>
        /// No se especificó ninguna operación de actualización del arsenal.
        /// </summary>
        NoSeEspecificanOperaciones = 300,
        /// <summary>
        /// Se especificaron más de 100 operaciones de modificación del arsenal.
        /// </summary>
        DemasiadasOperaciones = 301,
        /// <summary>
        /// El código o identificador de producto referenciado no existe en la base de datos de Pasamonte.
        /// </summary>
        NoExisteCodigoProducto = 302,
        /// <summary>
        /// NoExisteItemEntrega - el código del item de la entrega (prescripción) no existe.
        /// </summary>
        NoExisteItemEntrega = 303,
        /// <summary>
        /// ErrorCantidadDispensada - error en la cantidad dispensada
        /// </summary>
        ErrorCantidadDispensada = 304,
        /// <summary>
        /// ErrorUnidadDispensada - error en la unidad dispensada
        /// </summary>
        ErrorUnidadDispensada = 305,
        /// <summary>
        /// ErrorEstadoReceta - el estado de la receta no es válido o bien no es válido para realizar operaciones.
        /// </summary>
        ErrorEstadoReceta = 306,
        ErrorCitaNoExiste = 400
    }
    #endregion
}
