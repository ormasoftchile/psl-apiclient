using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class QueryObtenerCitas
    {
        public Guid? sistemaConsultaId { get; set; }
        public Guid? id { get; set; }
        public Guid? sistemaDeOrigenId { get; set; }
        public string idEnSistemaDeOrigen { get; set; }
        public EstadoCita[] estados { get; set; }
        public QueryObtenerPersonas persona { get; set; }
        public DateTime? fechaHoraInicioMin { get; set; }
        public DateTime? fechaHoraInicioMax { get; set; }
        public DateTime? fechaHoraLlegadaMin { get; set; }
        public DateTime? fechaHoraLlegadaMax { get; set; }
        public DateTime? fechaHoraTerminoMin { get; set; }
        public DateTime? fechaHoraTerminoMax { get; set; }
        public DateTime? fechaHoraAsignacionMin { get; set; }
        public DateTime? fechaHoraAsignacionMax { get; set; }
        public MedioDeReservaCita[] medioDeReserva { get; set; }
        public bool? esGrupal { get; set; }
        public TipoDeAtencionCita[] tipoDeAtencion { get; set; }
        public string instrumento { get; set; }
        public string codigoEstablecimiento { get; set; }
        public Guid[] nodoId { get; set; }
        public string tokenDeLlamada { get; set; }
        public string[] identificadorProfesional { get; set; }
        public string[] sector { get; set; }
    }
}
