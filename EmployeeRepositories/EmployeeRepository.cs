using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeRepositories.Data;
using EmployeeRepositories.DTO;

namespace EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EfCoreDbContext db;
        public EmployeeRepository() { }
        public EmployeeRepository(EfCoreDbContext context)
        {
            this.db = context;  
        }
        public List<EmployeeDTO> GetEmployees()
        {
            EmployeeDTO employeeDTO= new EmployeeDTO(); 
           // employee.Department.ToString();
            var q = db.Employees.Select(e => new EmployeeDTO
            {
                EmployeeName = e.EmployeeName,
                DepartmentName = e.Department.DepartmentName,
                EmployeeId = e.EmployeeId,
                Salary = e.Salary,
                JoinDate = e.JoinDate

            }).ToList();

            return q;
        }
    }
}
