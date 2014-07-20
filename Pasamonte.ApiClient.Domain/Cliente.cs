using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Domain
{
    public class Cliente : AuditInfoComplete
    {
        /// <summary>
        /// Post identity
        /// </summary>
        [Key]
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// RazonSocial
        /// </summary>
        [Required]
        [StringLength(200)]
        [DataMember]
        public string RazonSocial { get; set; }

        /// <summary>
        /// RUT Cliente
        /// </summary>
        [Required]
        [StringLength(100)]
        [DataMember]
        public string RUT { get; set; }

        /// <summary>
        /// Activo
        /// </summary>
        [Required]
        [DataMember]
        public bool Activo { get; set; }

        /// <summary>
        /// Bloqueado
        /// </summary>
        [Required]
        [DataMember]
        public bool Bloqueado { get; set; }

        /// <summary>
        /// Fecha ingreso
        /// </summary>
        [Required]
        [DataMember]
        public DateTime FechaIngreso { get; set; }

        /// <summary>
        /// Related Tags
        /// </summary>
        [DataMember]
        public ICollection<ClienteTag> ClienteTags { get; set; }

        [DataMember]
        [MaxLength(256)]
        public string ApiKey { get; set; }
    }

    /// <summary>
    /// Tags for the Nodos
    /// </summary>
    [DataContract(IsReference = true)]
    public class ClienteTag : BaseTag<Cliente>
    {
    }
}
