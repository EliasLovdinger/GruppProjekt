using GruppProjekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace Grupp6_ovning.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
