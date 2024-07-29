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
    public class DoctoresModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe introducir el Consultorio al que pertenece este Doctor.")]
        [ForeignKey("ConsultoriosModelId")]
        public virtual Consultorios? Consultorio { get; set; }
        //public virtual ICollection<Consultorios> ConsultorioID { get; set; } = new List<Consultorios>();
        //public virtual Usuarios? Usuario { get; set; }
        public virtual ICollection<Citas> Cita { get; set; } = new List<Citas>();
        //public virtual Citas? Citas { get; set; }

        [Required(ErrorMessage = "Debe introducir el nombre de este Doctor")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe introducir el Genero de este Doctor.")]
        [ForeignKey("GenerosModelId")]
        public virtual Generos? Genero { get; set; }
        //public string Genero { get; set; } = string.Empty;

        [Phone]
        public string Telefono { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        /*
        public virtual Consultorios? Consultorio { get; set; }
        //public virtual ICollection<Consultorios> ConsultorioID { get; set; } = new List<Consultorios>();
        public virtual Usuarios? Usuario { get; set; }
        public virtual ICollection<Citas> Cita { get; set; } = new List<Citas>();
        //public virtual Citas? Citas { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        /*
        public string Nombre { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public virtual ICollection<Consultorios> ConsultorioID { get; set; } = new List<Consultorios>();
        //public virtual Citas? Citas { get; set; }
        public virtual ICollection<Citas> Cita { get; set; } = new List<Citas>();
        */
        /*
        public string Nombre { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public virtual ICollection<Consultorios> ConsultorioID { get; set; } = new List<Consultorios>();
        public virtual Citas? Citas { get; set; }
        */
    }
}
