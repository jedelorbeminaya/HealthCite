using HealthCite.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCite.Infrastructure.Models
{
    public class DoctoresModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe introducir el Genero de este Doctor.")]
        [ForeignKey("Genero")]
        public virtual Generos? Genero { get; set; }

        [Required(ErrorMessage = "Debe introducir el Consultorio al que pertenece este Doctor.")]
        [ForeignKey("Consultorio")]
        public virtual Consultorios? Consultorio { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
