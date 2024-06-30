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
        public string Rol { get; set; } = string.Empty;
        public virtual Usuarios? UsuariosID { get; set; }
    }
}
