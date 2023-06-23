using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Repositories.Concrete
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class, new()
    {
        public T Add(T entity)
        {
            using (NowadaysContext context = new NowadaysContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public bool Delete(T entity)
        {
            using (NowadaysContext context = new NowadaysContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                if (context.SaveChanges() > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (NowadaysContext context = new NowadaysContext())
            {
                return context.Set<T>().FirstOrDefault(filter);
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (NowadaysContext context = new NowadaysContext())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }

        public bool Update(T entity)
        {
            using (NowadaysContext context = new NowadaysContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                if (context.SaveChanges() > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }

}
