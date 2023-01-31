using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeRepositories;

namespace LayeredApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeRepository empRepo;
        public EmployeesController(IEmployeeRepository empRepo)
        {
            this.empRepo = empRepo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            
            var empList = empRepo.GetEmployees();
            return Ok(empList);
        }
    }
}
