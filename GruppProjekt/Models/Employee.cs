

namespace GruppProjekt.Models
{
    public class Employee
    {


        public int EmployeeId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string Email { get; set; }
        public string PassWord { get; set; }


        public int VacationDays { get; set; }


        public List<Application> Applications { get; set; }

        
    }
}
