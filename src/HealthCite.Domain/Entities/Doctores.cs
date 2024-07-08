using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Doctores : BaseEntity
    {
        public virtual Consultorios? Consultorio { get; set; }
        //public virtual ICollection<Consultorios> ConsultorioID { get; set; } = new List<Consultorios>();
        public virtual Usuarios? Usuario { get; set; }
        public virtual ICollection<Citas> Cita { get; set; } = new List<Citas>();
        //public virtual Citas? Citas { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        
    }
}
