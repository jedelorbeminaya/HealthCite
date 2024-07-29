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
    public class CitasModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="Debe introducir el Paciente al que hace referencia.")]
        [ForeignKey("PacientesModelId")]
        public virtual Pacientes? Paciente { get; set; }
        //public virtual ICollection<Pacientes> PacienteID { get; set; } = new List<Pacientes>(); 
        [Required(ErrorMessage = "Debe introducir el Doctor de referencia disponible para el consultorio al que se dirije.")]
        [ForeignKey("DoctoresModelId")]
        public virtual Doctores? Doctor { get; set; }
        //public virtual ICollection<Doctores> DoctoresID { get; set; } = new List<Doctores>();
        [Required(ErrorMessage = "Debe introducir Consultorio de referencia al que se dirige.")]
        [ForeignKey("ConsultoriosModelId")]
        public virtual Consultorios? Consultorio { get; set; }
        //public virtual ICollection<Consultorios> ConsultorioID { get; set; } = new List<Consultorios>();
        
        [Required(ErrorMessage = "Estado de Cita no destacado.")]
        [ForeignKey("EstadoCitasModelId")]
        public virtual EstadoCitas? EstadoCita { get; set; }

        [Required(ErrorMessage = "Fecha de Cita NO INDICADA.")]
        public string FechaCita { get; set; } = string.Empty;

        [Required(ErrorMessage = "Motivo de Cita NO INDICADO.")]
        public string Motivo { get; set; } = string.Empty;
        /*
        public virtual Pacientes? Paciente { get; set; }
        //public virtual ICollection<Pacientes> PacienteID { get; set; } = new List<Pacientes>(); 
        public virtual Doctores? Doctor { get; set; }
        //public virtual ICollection<Doctores> DoctoresID { get; set; } = new List<Doctores>();
        public virtual Consultorios? Consultorio { get; set; }
        //public virtual ICollection<Consultorios> ConsultorioID { get; set; } = new List<Consultorios>();
        public virtual EstadoCitas? EstadoCita { get; set; }
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; } = string.Empty;
        */
        /*
        public virtual Pacientes? Paciente { get; set; }
        //public virtual ICollection<Pacientes> PacienteID { get; set; } = new List<Pacientes>(); 
        public virtual Doctores? Doctor { get; set; }
        //public virtual ICollection<Doctores> DoctoresID { get; set; } = new List<Doctores>();
        public virtual ICollection<Consultorios> ConsultorioID { get; set; } = new List<Consultorios>();
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public virtual ICollection<EstadoCitas> EstadoID { get; set; } = new List<EstadoCitas>();
        */
        /*
        public virtual ICollection<Pacientes> PacienteID { get; set; } = new List<Pacientes>();
        public virtual ICollection<Doctores> DoctoresID { get; set; } = new List<Doctores>();
        public virtual ICollection<Consultorios> ConsultorioID { get; set; } = new List<Consultorios>();
        public DateTime FechaCita { get; set; }
        public string Motivo { get; set; } = string.Empty;
        public virtual ICollection<EstadoCitas> EstadoID { get; set; } = new List<EstadoCitas>();
        */
    }
}
