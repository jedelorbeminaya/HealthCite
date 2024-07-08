using HealthCite.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Domain.Entities
{
    public class Especialidades:BaseEntity
    {
        public virtual ICollection<Consultorios> Consultorios { get; set; } = new List<Consultorios>();
        //public virtual Consultorios? Consultorio { get; set; } 
        public string Especialidad { get; set; } = string.Empty;
    
    }
}
