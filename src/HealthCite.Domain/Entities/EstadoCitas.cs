﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCite.Domain.Core;

namespace HealthCite.Domain.Entities
{
    public class EstadoCitas : BaseEntity
    {
        public string Estado { get; set; } = string.Empty;
        public virtual Citas? CitaID { get; set; } 
    }
}
