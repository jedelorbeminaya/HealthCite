using HealthCite.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCite.Infrastructure.Models
{
    public class CitasModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe introducir su nombre como paciente.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir su fecha de naciento.")]
        public string? FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Debe introducir su Genero.")]
        [ForeignKey("Genero")]
        public virtual Generos? Genero { get; set; }

        [Required(ErrorMessage = "Debe introducir su Correo Electronico.")]
        public string CorroElectronico { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe introducir Consultorio de referencia al que se dirige.")]
        [ForeignKey("Consultorio")]
        public virtual Consultorios? Consultorio { get; set; }

        [Required(ErrorMessage = "Fecha de Cita NO INDICADA.")]
        public string FechaCita { get; set; } = string.Empty;

        [Required(ErrorMessage = "Motivo de Cita NO INDICADO.")]
        public string Motivo { get; set; } = string.Empty;
    }
}
