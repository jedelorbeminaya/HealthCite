using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Doctor : Persona
    {
        public string Especialidad { get; set; } = string.Empty;
        public int DepartamentoId { get; set; }
        public Departamentos Departamento { get; set; } = new Departamentos();
    }
}
