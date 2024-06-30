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
        public string Nombre { get; set; } = string.Empty;
        public virtual ICollection<Especialidades> EspecialidadID { get; set; } = new List<Especialidades>();
        public virtual Doctores? Doctores { get; set; }
        public virtual Citas? CitasID { get; set; } 
    }
}
