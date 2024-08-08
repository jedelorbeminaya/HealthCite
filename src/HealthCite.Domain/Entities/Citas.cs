using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Citas : BaseEntity
    {
        public virtual Generos? Genero { get; set; }

        public virtual Consultorios? Consultorio { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string FechaNacimiento { get; set; } = string.Empty;

        public string CorroElectronico { get; set; } = string.Empty;

        public string FechaCita { get; set; } = string.Empty;

        public string Motivo { get; set; } = string.Empty;
    }
}
