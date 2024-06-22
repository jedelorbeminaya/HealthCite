using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCite.Infrastructure.Context.Exceptions
{
    public class CitaException
    {
        public class AppointmentException : Exception
        {
            public AppointmentException(string message) : base(message) { }
        }

        public class DepartmentException : Exception
        {
            public DepartmentException(string message) : base(message) { }
        }

        public class DoctorException : Exception
        {
            public DoctorException(string message) : base(message) { }
        }

        public class PatientException : Exception
        {
            public PatientException(string message) : base(message) { }
        }
    }
}
