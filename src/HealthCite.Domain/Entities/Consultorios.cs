using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Consultorios : BaseEntity
    {
        public virtual Especialidades? Especialidad { get; set; }
        public virtual ICollection<Doctores> Doctores { get; set; } = new List<Doctores>();
        //public virtual Doctores? Doctores { get; set; }
        public virtual ICollection<Citas> Citas { get; set; } = new List<Citas>();
        //public virtual Citas? Citas { get; set; } 
        public string Nombre { get; set; } = string.Empty;
        //public virtual ICollection<Especialidades> Especialidad { get; set; } = new List<Especialidades>();
        
    }
}
