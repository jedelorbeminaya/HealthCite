using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Domain.Repositories
{
    public interface IRepository
    {
        IRepository GetCitaById(int CitaId);
        void Cita(IRepository Cita);
        void UpdateCita(IRepository Cita);
        void DeleteCita(int CitaId);

    }

}
