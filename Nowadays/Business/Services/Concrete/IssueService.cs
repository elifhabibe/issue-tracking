using Business.Services.Abstract;
using DataAccess.Repositories.Abstract;
using DataAccess.Repositories.Concrete;
using Entity.Models;

namespace Business.Services.Concrete
{
    public class IssueService : IIssueService
    {
        IIssueDal _issueDal = new IssueDal();
        public Issue Add(Issue issue)
        {
            return _issueDal.Add(issue);
        }

        public bool Delete(int id)
        {
            return _issueDal.Delete(new Issue() { Id = id });
        }

        public List<Issue> GetAll()
        {
            return _issueDal.GetAll();
        }

        public Issue GetIssue(int id)
        {
            return _issueDal.Get(x => x.Id == id);
        }

        public bool Update(Issue issue)
        {
            return _issueDal.Update(issue);
        }
    }
}
