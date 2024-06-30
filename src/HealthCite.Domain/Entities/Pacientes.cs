using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class Pacientes : BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;
        //public virtual ICollection<Generos> GeneroId { get; set; } = new List<Generos>();
        public string Genero { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public virtual HistorialMedico? HistorialMedicoID { get; set; }
        public virtual Citas? Citas { get; set; }
    }
}
