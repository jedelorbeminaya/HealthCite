using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Consultorios : BaseEntity
    {
        public string nombre { get; set; }
        public int especialidad_id { get; set; }
    }
}
