using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Models
{
    public class PacientesModel
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public int Genero_id { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
    }
}
