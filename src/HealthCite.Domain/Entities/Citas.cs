using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Citas : BaseEntity
    {
        public int paciente_id { get; set; }
        public int doctores_id { get; set; }
        public int consultorio_id { get; set; }
        public DateTime fechaCita { get; set; }
        public string motivo { get; set; }
        public int estado_id { get; set; }
    }
}
