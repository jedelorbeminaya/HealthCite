using HealthCite.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Domain.Entities
{
    public class Usuarios:BaseEntity
    {
        public virtual Roles? Rol { get; set; }
        //public virtual ICollection<Roles> RolID { get; set; } = new List<Roles>();
        public virtual ICollection<Pacientes> Pacientes { get; set; } = new List<Pacientes>();
        public virtual ICollection<Doctores> Doctores { get; set; } = new List<Doctores>();
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;
        
    }
}
