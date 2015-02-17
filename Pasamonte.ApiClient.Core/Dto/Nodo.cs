using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class Nodo
    {
        /// <summary>
        /// Post identity
        /// </summary>
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }
        public Guid? id { get; set; }

        /// <summary>
        /// Identificador del tipo de nodo
        /// </summary>
        public Guid idTipoNodo { get; set; }

        /// <summary>
        /// Titulo
        /// </summary>
        public string titulo { get; set; }

        /// <summary>
        /// Descripcion for this article
        /// </summary>
        public string descripcion { get; set; }

        /// <summary>
        /// Url for the image representing the post
        /// </summary>
        public string urlImagen { get; set; }

        /// <summary>
        /// If the article is published and visible to others or not
        /// </summary>
        public bool publico { get; set; }

        /// <summary>
        /// IdNodoPadre
        /// </summary>
        public Guid? idNodoPadre { get; set; }

        /// <summary>
        /// CodigoPublico - codigo oficial del nodo
        /// </summary>
        public string codigoPublico { get; set; }
    }
}
