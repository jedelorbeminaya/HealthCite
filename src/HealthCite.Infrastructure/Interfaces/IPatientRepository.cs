using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Interfaces
{
    public interface IPatientRepository
    {
        Paciente GetPatientById(int patientId);
        Paciente GetPacienteByName(string name);
        Paciente UpdatePatientById(int patientId);
        Paciente DeletePatientById(int patientId);

    }
}