using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Interfaces
{
    public interface IDoctorRepository
    {
        Doctor GetDoctorById(int doctorid);
        Doctor GetDoctorByName(string name);
        Doctor UpdateDoctor(Doctor doctor);
        Doctor DeleteDoctor(int doctorId);
    }

}
