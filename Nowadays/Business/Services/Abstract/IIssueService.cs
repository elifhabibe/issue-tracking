using Entity.Models;

namespace Business.Services.Abstract
{
    public interface IIssueService
    {
        Issue GetIssue(int id);
        List<Issue> GetAll();
        Issue Add(Issue issue);
        bool Update(Issue issue);
        bool Delete(int id);
    }
}
