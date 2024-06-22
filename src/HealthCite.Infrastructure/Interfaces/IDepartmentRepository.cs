using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HealthCite.Infrastructure.Interfaces
{
    public interface IDepartmentRepository
    {
        Departamentos GetDepartmentById(int departamentoid);
        Departamentos UpdateDepartmentById(int departamentoId);
        Departamentos DeleteDepartmentById(int departamentoId);
    }
}
