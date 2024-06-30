using HealthCite.Domain.Entities;
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
        public virtual ICollection<Pacientes> PacienteID { get; set; } = new List<Pacientes>();
        public string Antecedentes { get; set; } = string.Empty;
        public string Enfermedad { get; set; } = string.Empty;
        public string MedicacionesActuales { get; set; } = string.Empty;
        public string Notas { get; set; } = string.Empty;
    }
}
