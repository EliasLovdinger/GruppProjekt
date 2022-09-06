

namespace GruppProjekt.Models
{
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly AppDbContext  _dbContext;


        public ApplicationRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateApplication(Application application)
        {
            application.RequestDate = DateTime.Now;

            _dbContext.Applications.Add(application);

            _dbContext.SaveChanges();

        }

        public IEnumerable<Application> GetAllApplications()
        {
            return _dbContext.Applications;
        }

        public Application GetApplicationById(int id)
        {

            return _dbContext.Applications.FirstOrDefault(a => a.ApplicationId == id);

        }
        public Application UpdateApplication(Application application)
        {
            var newApplication = _dbContext.Applications.FirstOrDefault(a => a.ApplicationId == application.ApplicationId);


            if (newApplication.ApplicationId == application.ApplicationId)
            {
                _dbContext.Applications.Update(application);
                _dbContext.SaveChanges();
            }

            return application;


        }
    }
}
