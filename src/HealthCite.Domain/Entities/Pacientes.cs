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
        public virtual ICollection<Citas> Citas { get; set; } = new List<Citas>();
        //public virtual Citas? Citas { get; set; }
        public virtual Usuarios? Usuario { get; set; }
        //public virtual ICollection<Usuarios> Usuario { get; set; } = new List<Usuarios>();
        public string Nombre { get; set; } = string.Empty;
        //public virtual ICollection<Generos> GeneroId { get; set; } = new List<Generos>();
        public string Genero { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        //public virtual HistorialMedico? HistorialMedicoID { get; set; 
    }
}
