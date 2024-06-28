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
        public string nombre { get; set; }
        public string email { get; set; }
        public string clave { get; set; }
        public int rol_id { get; set; }
    }
}
