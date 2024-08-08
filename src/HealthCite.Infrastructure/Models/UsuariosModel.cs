using HealthCite.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCite.Infrastructure.Models
{
    public class UsuariosModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Rol de Usuario NO indicado.")]
        [ForeignKey("Rol")]
        public virtual Roles? Rol { get; set; }

        [Required(ErrorMessage = "Nombre de Usuario NO indicado.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Correo Electronico de acceso NO valido o NO indicado.")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Contraseña de accedo NO indicada.")]
        [PasswordPropertyText]
        public string? Clave { get; set; }

    }
}
