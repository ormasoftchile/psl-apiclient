using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Domain
{
    /// <summary>
    /// Representa un nodo de la red
    /// </summary>
    [DataContract(IsReference = true)]
    public class TipoNodo
    {
        /// <summary>
        /// Post identity
        /// </summary>
        [Key]
        [DataMember]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        public Guid Id { get; set; }

        [DataMember]
        public Guid? IdPadre { get; set; }

        /// <summary>
        /// NodoPadre
        /// </summary>
        [ForeignKey("IdPadre")]
        [DataMember]
        public TipoNodo TipoNodoPadre { get; set; }

        /// <summary>
        /// Titulo
        /// </summary>
        [Required]
        [StringLength(200)]
        [DataMember]
        public string Titulo { get; set; }

        /// <summary>
        /// Descripcion for this article
        /// </summary>
        [Required]
        [StringLength(500)]
        [DataMember]
        public string Descripcion { get; set; }

        /// <summary>
        /// Related Tags
        /// </summary>
        [DataMember]
        public ICollection<Nodo> Nodos { get; set; }
    }
}
