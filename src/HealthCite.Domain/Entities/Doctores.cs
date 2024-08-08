using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Doctores : BaseEntity
    {
        public virtual Generos? Genero { get; set; }
        public virtual Consultorios? Consultorio { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

    }
}
