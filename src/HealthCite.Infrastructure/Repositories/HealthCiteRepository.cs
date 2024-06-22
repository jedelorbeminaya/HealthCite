using HealthCite.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Repositories
{
    public class HealthCiteRepository
    {
        public interface IAppointmentRepository
        {
            Task<CitaModel> GetByIdAsync(int id);
            Task<IEnumerable<CitaModel>> GetAllAsync();
            Task AddAsync(CitaModel cita);
            void Update(CitaModel cita);
            void Delete(CitaModel cita);
        }
    }
}
