﻿using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Models
{
    public class ConsultoriosModel
    {
        public int Id { get; set; }
        public virtual Especialidades? Especialidad { get; set; }
        public virtual ICollection<Doctores> Doctores { get; set; } = new List<Doctores>();
        //public virtual Doctores? Doctores { get; set; }
        public virtual ICollection<Citas> Citas { get; set; } = new List<Citas>();
        //public virtual Citas? Citas { get; set; } 
        public string Nombre { get; set; } = string.Empty;
        //public virtual ICollection<Especialidades> Especialidad { get; set; } = new List<Especialidades>();
        /*
        public string Nombre { get; set; } = string.Empty;
        public virtual ICollection<Especialidades> EspecialidadID { get; set; } = new List<Especialidades>();
        public virtual Doctores? Doctores { get; set; }
        public virtual Citas? Citas { get; set; }
        */
        /*
        public string Nombre { get; set; } = string.Empty;
        public virtual ICollection<Especialidades> EspecialidadID { get; set; } = new List<Especialidades>();
        public virtual Doctores? Doctores { get; set; }
        public virtual Citas? CitasID { get; set; }
        */
    }

}
