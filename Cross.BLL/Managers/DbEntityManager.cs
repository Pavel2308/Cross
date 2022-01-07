using Cross.DAL;
using Cross.Model.Common;
using System.Collections.Generic;
using System.Linq;

namespace Cross.BLL.Managers
{
    public class DbEntityManager<TEntity> where TEntity : class, IDbEntity
    {
        private readonly CrossContext _dbContext;

        public DbEntityManager(CrossContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual TEntity Find(int id)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(e => e.Id == id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }

        public virtual void Save(TEntity model)
        {
            if (model.Id == 0)
                _dbContext.Add(model);
            else
                _dbContext.Update(model);

            _dbContext.SaveChanges();
        }

        public virtual void Remove(int id)
        {
            var entity = _dbContext.Set<TEntity>().Find(id);
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
