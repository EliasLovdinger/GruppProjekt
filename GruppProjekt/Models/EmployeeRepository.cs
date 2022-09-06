

namespace GruppProjekt.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _DbContext;

        public EmployeeRepository(AppDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public IEnumerable<Employee> GetAllEmployees => _DbContext.Employees;

        public Employee GetEmployeeById(int id)
        {
            return _DbContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }
    }
}
