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
        public string nombre { get; set; }
        public string email { get; set; }
        public string clave { get; set; }
        public int rol_id { get; set; }
    }
}
