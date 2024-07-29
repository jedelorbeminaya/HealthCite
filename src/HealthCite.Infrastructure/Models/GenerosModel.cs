using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class GenerosModel
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Pacientes> Doctores { get; set; } = new List<Pacientes>();
        public virtual ICollection<Doctores> Citas { get; set; } = new List<Doctores>();

        [Required(ErrorMessage = "Debe introducir el nombre del Genero.")]
        public string Genero { get; set; } = string.Empty;
        
    }
}
