using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Usuarios : BaseEntity
    {
        public virtual Roles? Rol { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;

    }
}
