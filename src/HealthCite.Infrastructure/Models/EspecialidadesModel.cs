using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Models
{
    public class EspecialidadesModel
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Consultorios> Consultorios { get; set; } = new List<Consultorios>();
        //public virtual Consultorios? Consultorio { get; set; } 

        [Required(ErrorMessage = "Debe introducir el nombre de la Especialidad")]
        public string Especialidad { get; set; } = string.Empty;
        /*
        public virtual ICollection<Consultorios> Consultorios { get; set; } = new List<Consultorios>();
        //public virtual Consultorios? Consultorio { get; set; } 
        public string Especialidad { get; set; } = string.Empty;
        /*
        public string Especialidad { get; set; } = string.Empty;
        public virtual Consultorios? ConsultorioID { get; set; }
        */

    }
}
