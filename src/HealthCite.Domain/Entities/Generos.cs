using HealthCite.Domain.Core;
using System.ComponentModel;

namespace HealthCite.Domain.Entities
{
    public class Generos : BaseEntity
    {

        public virtual ICollection<Doctores> Doctores { get; set; } = new List<Doctores>();
        public ICollection<Citas>? Citas { get; set; }

        [DisplayName("Genero")]
        public string? Genero { get; set; }

    }
}
