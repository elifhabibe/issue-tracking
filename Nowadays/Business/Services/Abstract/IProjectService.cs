
using Entity.Models;

namespace Business.Services.Abstract
{
    public interface IProjectService
    {
        Project GetProject(int id);
        List<Project> GetAll();
        Project Add(Project project);
        bool Update(Project project);
        bool Delete(int id);
    }
}
