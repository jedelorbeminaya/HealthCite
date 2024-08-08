using HealthCite.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCite.Infrastructure.Models
{
    public class ConsultoriosModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe introducir la especialidad del Consultorio.")]
        [ForeignKey("Especialidad")]
        public virtual Especialidades? Especialidad { get; set; }

        public virtual ICollection<Doctores> Doctores { get; set; } = new List<Doctores>();
        public virtual ICollection<Citas> Citas { get; set; } = new List<Citas>();


        [Required(ErrorMessage = "Debe introducir el nombre del Consultorio.")]
        public string Nombre { get; set; } = string.Empty;
    }

}
