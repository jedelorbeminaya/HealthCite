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
        public string Especialidad { get; set; } = string.Empty;
        public virtual Consultorios? ConsultorioID { get; set; } 
    }
}
