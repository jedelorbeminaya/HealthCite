using HealthCite.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace HealthCite.Infrastructure.Models
{
    public class EspecialidadesModel
    {
        [Key]
        public int Id { get; set; }
        public virtual ICollection<Consultorios> Consultorios { get; set; } = new List<Consultorios>();

        [Required(ErrorMessage = "Debe introducir el nombre de la Especialidad")]
        public string Especialidad { get; set; } = string.Empty;

    }
}
