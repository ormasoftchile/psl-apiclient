using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Domain
{
    /// <summary>
    /// Tags for the T
    /// </summary>
    [DataContract(IsReference = true)]
    public class BaseTag<T>
    {
        //[Key]
        [DataMember]
        public Guid TagId { get; set; }

        /// <summary>
        /// Tag Name
        /// </summary>
        //[Required]
        //[StringLength(100)]
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Related Object Id
        /// </summary>        
        [DataMember]
        //public int ObjectId { get; set; }
        public Guid ObjectId { get; set; }

        /// <summary>
        /// Related Object
        /// </summary>
        //[ForeignKey("ObjectId")]
        [DataMember]
        public T Object { get; set; }
    }
}
