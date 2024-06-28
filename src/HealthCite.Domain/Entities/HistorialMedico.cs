using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class HistorialMedico : BaseEntity
    {
        public int paciente_id { get; set; }
        public string antecedentes { get; set; }
        public string enfermedad { get; set; }
        public string medicaciones_actuales { get; set; }
        public string notas { get; set; }
    }
}
