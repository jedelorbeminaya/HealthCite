using HealthCite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HealthCite.Domain.Repository
{
    public interface IDepartmentRepository
    {
        Consultorios GetDepartmentById(int departamentoid);
        Consultorios UpdateDepartmentById(int departamentoId);
        Consultorios DeleteDepartmentById(int departamentoId);
    }
}
