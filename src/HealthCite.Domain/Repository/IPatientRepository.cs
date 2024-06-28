using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Domain.Repository
{
    public interface IPatientRepository
    {
        Pacientes GetPatientById(int patientId);
        Pacientes GetPacienteByName(string name);
        Pacientes UpdatePatientById(int patientId);
        Pacientes DeletePatientById(int patientId);

    }
}