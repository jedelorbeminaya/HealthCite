﻿using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Models
{
    public class EspecialidadesModel
    {
        public int Id { get; set; }
        public virtual ICollection<Consultorios> Consultorios { get; set; } = new List<Consultorios>();
        //public virtual Consultorios? Consultorio { get; set; } 
        public string Especialidad { get; set; } = string.Empty;
        /*
        public string Especialidad { get; set; } = string.Empty;
        public virtual Consultorios? ConsultorioID { get; set; }
        */

    }
}
