using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Departamentos : Persona
    {
        public string Especialidad { get; set; } = string.Empty;
    }
}
