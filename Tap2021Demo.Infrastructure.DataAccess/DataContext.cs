using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Tap2021Demo.Infrastructure.DataAccess
{
    public class DataContext : DbContext, IDataRepository, IUnitOfWork
    {
        public DataContext(DbContextOptions<DataContext> contextOptions) : base(contextOptions)
        {

        }

        public void Commit()
        {
            SaveChanges();
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            Delete(entity);
        }

        public TEntity Insert<TEntity>(TEntity entity) where TEntity : class
        {
            return Insert(entity);
        }

        public IQueryable<TEntity> Query<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        void IDataRepository.Update<TEntity>(TEntity entity)
        {
            Update(entity);
        }
    }
}
