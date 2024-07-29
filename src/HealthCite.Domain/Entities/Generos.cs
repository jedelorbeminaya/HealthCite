using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Generos : BaseEntity
    {
        public virtual ICollection<Pacientes> Doctores { get; set; } = new List<Pacientes>();
        public virtual ICollection<Doctores> Citas { get; set; } = new List<Doctores>(); 
        public string Genero { get; set; } = string.Empty;
        
    }
}
