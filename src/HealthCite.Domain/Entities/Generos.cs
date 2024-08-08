using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Generos : BaseEntity
    {

        public virtual ICollection<Doctores> Doctores { get; set; } = new List<Doctores>();
        public virtual ICollection<Citas> Citas { get; set; } = new List<Citas>();
        
        public string Genero { get; set; } = string.Empty;

    }
}
