using HealthCite.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace HealthCite.Infrastructure.Models
{
    public class RolesModel
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();

        [Required(ErrorMessage = "Nombre de Rol NO introducido.")]
        public string Rol { get; set; } = string.Empty;
    }
}
