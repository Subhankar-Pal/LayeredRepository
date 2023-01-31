using EmployeeRepositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepositories.DTO
{
    public class EmployeeDTO
    {
        public short EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? DepartmentName { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? JoinDate { get; set; }

    }
}
