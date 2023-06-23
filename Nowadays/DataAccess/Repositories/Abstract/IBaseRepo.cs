using System.Linq.Expressions;

namespace DataAccess.Repositories.Abstract
{
    public interface IBaseRepo<T> where T : class, new()
    {
        T Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }

}
