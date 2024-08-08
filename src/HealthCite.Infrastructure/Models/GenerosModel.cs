using System.ComponentModel.DataAnnotations;

namespace HealthCite.Domain.Entities
{
    public class GenerosModel
    {
        [Key]
        public int Id { get; set; }
        
        public virtual ICollection<Doctores> Citas { get; set; } = new List<Doctores>();
        public virtual ICollection<Doctores> Doctores { get; set; } = new List<Doctores>();
        
        [Required(ErrorMessage = "Debe introducir el nombre del Genero.")]
        public string Genero { get; set; } = string.Empty;

    }
}
