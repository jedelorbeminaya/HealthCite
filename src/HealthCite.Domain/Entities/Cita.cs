using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Cita : BaseEntity
    {
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; } = new Doctor();

        public int PacienteID { get; set; }
        public Paciente Paciente { get; set; } = new Paciente();

        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Estado { get; set; } = string.Empty;
    }
}
