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
    public class PacientesModel
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Citas> Citas { get; set; } = new List<Citas>();
        //public virtual Citas? Citas { get; set; }
        //public virtual Usuarios? Usuario { get; set; }
        //public virtual ICollection<Usuarios> Usuario { get; set; } = new List<Usuarios>();
        
        [Required(ErrorMessage = "Nombre no introducido.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe indicar su Genero.")]
        [ForeignKey("GenerosModelId")]
        public virtual Generos? Genero { get; set; }
        //public string Genero { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe indicar su Fecha de nacimiento.")]
        public string? FechaNacimiento { get; set; }

        [Phone]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe indicar su Dirreccion")]
        public string? Direccion { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Debe indicar su Correo Electronico")]
        public string? Email { get; set; }
        //public virtual HistorialMedico? HistorialMedicoID { get; set}; 
        /*
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
        /*
        public string Nombre { get; set; } = string.Empty;
        //public virtual ICollection<Generos> GeneroId { get; set; } = new List<Generos>();
        public string Genero { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        //public virtual HistorialMedico? HistorialMedicoID { get; set; }
        public virtual ICollection<Citas> Citas { get; set; } = new List<Citas>();
        //public virtual Citas? Citas { get; set; }
        */
        /*
        public string Nombre { get; set; } = string.Empty;
        //public virtual ICollection<Generos> GeneroId { get; set; } = new List<Generos>();
        public string Genero { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        //public virtual HistorialMedico? HistorialMedicoID { get; set; }
        public virtual Citas? Citas { get; set; }
        */
    }
}
