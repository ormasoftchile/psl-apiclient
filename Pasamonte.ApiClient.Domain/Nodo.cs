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
    public class Nodo : AuditInfoComplete
    {
        /// <summary>
        /// Post identity
        /// </summary>
        [Key]
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// Identificador del tipo de nodo
        /// </summary>
        [DataMember]
        public Guid IdTipoNodo { get; set; }

        /// <summary>
        /// TipoNodo
        /// </summary>
        [ForeignKey("IdTipoNodo")]
        [DataMember]
        public TipoNodo TipoNodo { get; set; }

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
        /// Url for the image representing the post
        /// </summary>
        [Required]
        [StringLength(500)]
        [DataType(DataType.ImageUrl)]
        [DataMember]
        public string UrlImagen { get; set; }

        /// <summary>
        /// If the article is published and visible to others or not
        /// </summary>
        [DataMember]
        [Required]
        public bool Publico { get; set; }

        /// <summary>
        /// Related Tags
        /// </summary>
        [DataMember]
        public ICollection<NodoTag> NodoTags { get; set; }

        /// <summary>
        /// IdNodoPadre
        /// </summary>
        [DataMember]
        public Guid? IdNodoPadre { get; set; }

        /// <summary>
        /// NodoPadre
        /// </summary>
        [ForeignKey("IdNodoPadre")]
        [DataMember]
        public Nodo NodoPadre { get; set; }

        /// <summary>
        /// CodigoPublico - codigo oficial del nodo
        /// </summary>
        [DataMember]
        [MaxLength(256)]
        public string CodigoPublico { get; set; }
    }

    /// <summary>
    /// Tags for the Nodos
    /// </summary>
    [DataContract(IsReference = true)]
    public class NodoTag : BaseTag<Nodo>
    {
    }
}
