using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Models
{
    public class ConsultoriosModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public virtual ICollection<Especialidades> EspecialidadID { get; set; } = new List<Especialidades>();
        public virtual Doctores? Doctores { get; set; }
        public virtual Citas? CitasID { get; set; }

    }

}
