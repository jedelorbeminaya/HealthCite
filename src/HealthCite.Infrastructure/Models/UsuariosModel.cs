using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Models
{
    public class UsuariosModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Rol de Usuario NO indicado.")]
        [ForeignKey("RolesModelId")]
        public virtual Roles? Rol { get; set; }

        [Required(ErrorMessage = "Nombre de Usuario NO indicado.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Correo Electronico de acceso NO valido o NO indicado.")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Contraseña de accedo NO indicada.")]
        [PasswordPropertyText]
        public string? Clave { get; set; }
        /*
        public virtual Roles? Rol { get; set; }
        //public virtual ICollection<Roles> RolID { get; set; } = new List<Roles>();
        public virtual ICollection<Pacientes> Pacientes { get; set; } = new List<Pacientes>();
        public virtual ICollection<Doctores> Doctores { get; set; } = new List<Doctores>();
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;
        /*
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;
        public virtual ICollection<Roles> RolID { get; set; } = new List<Roles>();
        */
        /*
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Clave { get; set; } = string.Empty;
        public virtual Roles? Rol { get; set; }
        //public virtual ICollection<Roles> RolID { get; set; } = new List<Roles>();
        */
    }
}
