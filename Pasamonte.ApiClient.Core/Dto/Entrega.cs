using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class Entrega
    {
        /// <summary>
        /// Post identity
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// IdEnSistemaExterno - Id en el sistema remoto.
        /// </summary>
        /// Las entregas son recibidas desde un sistema externo.
        /// Este id representa la identificacion unica de la entrega en el sistema externo.
        public string IdEnSistemaExterno { get; set; }

        /// <summary>
        /// TipoEntrega - o tipo de receta según la codificación del proveedor de RCE.
        /// </summary>
        public string TipoEntrega { get; set; }

        /// <summary>
        /// FechaOrigen - Fecha reportada por el invocante.
        /// </summary>
        public string FechaOrigen { get; set; }

        /// <summary>
        /// Items - colección de items (o prescripciones) de la entrega (o receta).
        /// </summary>
        public ICollection<ItemEntrega> ItemsEntrega { get; set; }

        /// <summary>
        /// Related Object Id
        /// </summary>        
        public Guid PersonaId { get; set; }

        public Paciente Persona { get; set; }

        public bool Despachada { get; set; }

        /// <summary>
        /// FechaHoraDispensacion - describe la hora de dispensación. Formato: yyyyMMdd hh:mm.
        /// </summary>
        public DateTime? FechaHoraDispensacion { get; set; }

        /// <summary>
        /// UnidadDispensada - indica la unidad de dispensación del producto.
        /// </summary>
        public string UnidadDispensada { get; set; }

        /// <summary>
        /// Related Object Id
        /// </summary>        
        public Guid? TerminalId { get; set; }

        /// <summary>
        /// Id del nodo de la entrega
        /// </summary>
        public Guid? NodoId { get; set; }

        /// <summary>
        /// Parcial - indica si el despacho realizado se hizo de manera parcial, es decir,
        /// sin completar todos los items.
        /// </summary>
        public bool Parcial { get; set; }

        /// <summary>
        /// FechaProximoDespacho - para entregas notificadas, especifica la fecha de proximo
        /// despacho entregada por el RCE.
        /// </summary>
        public DateTime? FechaProximoDespacho { get; set; }
    }
}
