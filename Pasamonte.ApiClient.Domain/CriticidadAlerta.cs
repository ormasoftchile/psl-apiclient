using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Pasamonte.ApiClient.Domain
{

	/// <summary>
	/// Representa un nodo de la red
	/// </summary>
	[DataContract (IsReference = true)]
	public class CriticidadAlerta
	{
		/// <summary>
		/// Post identity
		/// </summary>
		[Key]
		[DataMember]
		public Guid Id { get; set; }

		/// <summary>
		/// Titulo
		/// </summary>
		[EnumDataType (typeof(CodigoCriticidadAlerta))]
		[Required]
		[DataMember]
		public CodigoCriticidadAlerta Codigo { get; set; }

		/// <summary>
		/// Titulo
		/// </summary>
		[Required]
		[StringLength (200)]
		[DataMember]        
		public string Titulo { get; set; }

		/// <summary>
		/// Descripcion
		/// </summary>
		[Required]
		[StringLength (500)]
		[DataMember]
		public string Descripcion { get; set; }
	}

	public enum CodigoCriticidadAlerta
	{
		NoDefinida = 1,
		Exito = 2,
		Informativa = 3,
		Advertencia = 4,
		Peligro = 5
	};
}

