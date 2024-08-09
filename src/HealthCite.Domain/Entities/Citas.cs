using HealthCite.Domain.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCite.Domain.Entities
{
    public class Citas
    {
        public int Id { get; set; }

        [ForeignKey("Genero")]
        public int GeneroId { get; set; }
        public Generos? Genero { get; set; }

        [ForeignKey("Consultorio")]
        public int ConsultorioId { get; set; }
        public Consultorios? Consultorio { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string FechaNacimiento { get; set; } = string.Empty;

        public string CorroElectronico { get; set; } = string.Empty;

        public string FechaCita { get; set; } = string.Empty;

        public string Motivo { get; set; } = string.Empty;
    }
}
