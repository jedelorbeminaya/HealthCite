﻿using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Models
{
    public class CitasModel
    {
        public int Id { get; set; }
        public virtual ICollection<Pacientes> PacienteID { get; set; } = new List<Pacientes>();
        public virtual ICollection<Doctores> DoctoresID { get; set; } = new List<Doctores>();
        public virtual ICollection<Consultorios> ConsultorioID { get; set; } = new List<Consultorios>();
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public virtual ICollection<EstadoCitas> EstadoID { get; set; } = new List<EstadoCitas>();
    }
}
