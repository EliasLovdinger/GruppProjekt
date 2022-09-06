namespace GruppProjekt.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees { get; }
        Employee GetEmployeeById(int id);

    }
}
