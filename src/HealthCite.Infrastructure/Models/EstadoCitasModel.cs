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
    public class EstadoCitasModel
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Citas> Citas { get; set; } = new List<Citas>();
        //public virtual Citas? CitaID { get; set; } 
        [Required(ErrorMessage = "Debe introducir la denominacion del Estado.")]
        public string Estado { get; set; } = string.Empty;
        /*
        public virtual ICollection<Citas> Citas { get; set; } = new List<Citas>();
        //public virtual Citas? CitaID { get; set; } 
        public string Estado { get; set; } = string.Empty;
        /*
        public string Estado { get; set; } = string.Empty;
        public virtual Citas? CitaID { get; set; }
        */
    }
}
