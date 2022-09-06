

namespace GruppProjekt.Models
{
    public interface IApplicationRepository
    {
        IEnumerable<Application> GetAllApplications();

        Application GetApplicationById(int id);

        void CreateApplication(Application application);

        Application UpdateApplication(Application application);
    }
}
