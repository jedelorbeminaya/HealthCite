using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Roles : BaseEntity
    {
        public virtual ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();

        public string Rol { get; set; } = string.Empty;

    }
}
