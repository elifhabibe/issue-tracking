using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using DataAccess.Repositories.Concrete;
using Entity.Models;

namespace Business.Services.Concrete
{
    public class ProjectService : IProjectService
    {
        IProjectDal _projectDal = new ProjectDal();
        public Project Add(Project project)
        {
            return _projectDal.Add(project);
        }

        public bool Delete(int id)
        {
            return _projectDal.Delete(new Project() { Id = id });
        }

        public List<Project> GetAll()
        {
            return _projectDal.GetAll();
        }

        public Project GetProject(int id)
        {
            return _projectDal.Get(x => x.Id == id);
        }

        public bool Update(Project project)
        {
            return _projectDal.Update(project);
        }
    }
}
