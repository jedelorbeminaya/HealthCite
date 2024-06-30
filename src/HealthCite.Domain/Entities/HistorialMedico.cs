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
        public virtual ICollection<Pacientes> PacienteID { get; set; } = new List<Pacientes>();
        public string Antecedentes { get; set; } = string.Empty;
        public string Enfermedad { get; set; } = string.Empty;
        public string MedicacionesActuales { get; set; } = string.Empty;
        public string Notas { get; set; } = string.Empty;
    }
}
