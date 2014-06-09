using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    /// <summary>
    /// Representa un nodo de la red
    /// </summary>
    public class ItemEntrega
    {
        /// <summary>
        /// Post identity
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// IdEnSistemaExterno - Id en el sistema remoto.
        /// </summary>
        /// Las entregas y sus items son recibidas desde un sistema externo.
        /// Este id representa la identificacion unica del item de la entrega en el sistema externo.
        public string IdEnSistemaExterno { get; set; }

        /// <summary>
        /// CantidadEntregar - cantidad en unidades a entregar del producto.
        /// </summary>
        public int CantidadEntregar { get; set; }

        /// <summary>
        /// DescripcionEntrega - glosa descriptiva
        /// </summary>
        public string DescripcionEntrega { get; set; }

        /// <summary>
        /// ObservacionEntrega - observaciones adjuntas de la entrega
        /// </summary>
        public string ObservacionEntrega { get; set; }

        /// <summary>
        /// Related Object Id
        /// </summary>        
        public Guid EntregaId { get; set; }

        /// <summary>
        /// IdentificadorProducto - código identificador del producto.
        /// </summary>
        public string IdentificadorProducto { get; set; }

        /// <summary>
        /// DescripcionProducto - glosa descriptiva del producto
        /// </summary>
        public string DescripcionProducto { get; set; }

        /// <summary>
        /// UnidadDispensacion - unidad de dispensación del producto
        /// </summary>
        public string UnidadDispensacion { get; set; }

        /// <summary>
        /// ???
        /// </summary>
        public bool EsSustituible { get; set; }
    }
}
