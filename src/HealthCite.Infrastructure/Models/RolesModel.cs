using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Models
{
    public class RolesModel
    {
        public int Id { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();
        //public virtual Usuarios? UsuariosID { get; set; } 
        public string Rol { get; set; } = string.Empty;
        /*
        public string Rol { get; set; } = string.Empty;
        public virtual ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();
        //public virtual Usuarios? UsuariosID { get; set; } 
        */
        /*
        public string Rol { get; set; } = string.Empty;
        public virtual Usuarios? UsuariosID { get; set; }
        */
    }
}
