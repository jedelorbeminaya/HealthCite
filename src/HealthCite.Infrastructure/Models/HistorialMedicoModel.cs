using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Models
{
    public class HistorialMedicoModel
    {
        public int Id { get; set; }
        public int paciente_id { get; set; }
        public string antecedentes { get; set; }
        public string enfermedad { get; set; }
        public string medicaciones_actuales { get; set; }
        public string notas { get; set; }
    }
}
