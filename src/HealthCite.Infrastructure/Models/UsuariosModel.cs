using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Models
{
    public class UsuariosModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;
        public virtual ICollection<Roles> RolID { get; set; } = new List<Roles>();
    }
}
