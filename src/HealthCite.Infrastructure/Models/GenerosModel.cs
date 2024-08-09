using System.ComponentModel.DataAnnotations;

namespace HealthCite.Domain.Entities
{
    public class GenerosModel
    {
        [Key]
        public int Id { get; set; }
        
        public ICollection<Citas>? Citas { get; set; } 
        public ICollection<Doctores>? Doctores { get; set; }
        
        [Required]
        public string? Genero { get; set; }

    }
}
