using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Especialidades : BaseEntity
    {
        public virtual ICollection<Consultorios> Consultorios { get; set; } = new List<Consultorios>();

        public string Especialidad { get; set; } = string.Empty;

    }
}
