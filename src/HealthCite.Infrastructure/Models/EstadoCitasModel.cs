using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Models
{
    public class EstadoCitasModel
    {
        public int Id { get; set; }
        public string Estado { get; set; } = string.Empty;
        public virtual Citas? CitaID { get; set; }
    }
}
