using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Consultorios : BaseEntity
    {
        public virtual Especialidades? Especialidad { get; set; }
        public virtual ICollection<Doctores> Doctores { get; set; } = new List<Doctores>();
        public virtual ICollection<Citas> Citas { get; set; } = new List<Citas>();
        public string Nombre { get; set; } = string.Empty;

    }
}
