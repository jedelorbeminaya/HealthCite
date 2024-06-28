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
        public string nombre { get; set; }
        public int genero_id { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public int consultorio_id { get; set; }
    }
}
