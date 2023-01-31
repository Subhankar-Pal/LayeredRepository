using EmployeeRepositories.Data;
using EmployeeRepositories.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        List<EmployeeDTO> GetEmployees();
    }
}
