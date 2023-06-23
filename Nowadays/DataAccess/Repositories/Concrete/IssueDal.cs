using DataAccess.Repositories.Abstract;
using Entity.Models;

namespace DataAccess.Repositories.Concrete
{
    public class IssueDal : BaseRepo<Issue>, IIssueDal
    {
    }
}
