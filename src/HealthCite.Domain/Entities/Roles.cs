using HealthCite.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Domain.Entities
{
    public class Roles:BaseEntity
    {
        public string Rol { get; set; } = string.Empty;
        public virtual Usuarios? UsuariosID { get; set; } 
    }
}
