using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Domain.Repository
{
    public interface IDoctorRepository
    {
        Doctores GetDoctorById(int doctorid);
        Doctores GetDoctorByName(string name);
        Doctores UpdateDoctor(Doctores doctor);
        Doctores DeleteDoctor(int doctorId);
    }

}
