using Cross.DAL;
using Cross.Model.Common;

namespace Cross.BLL.Managers
{
    public class CancellationDbEntityManager<TEntity> : DbEntityManager<TEntity> where TEntity : class, IDbEntity, ICancellationDbEntity
    {
        private readonly CrossContext _dbContext;

        public CancellationDbEntityManager(CrossContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Cancel(int id)
        {
            var model = _dbContext.Set<TEntity>().Find(id);
            model.IsCancelled = !model.IsCancelled;
            _dbContext.Update(model);
            _dbContext.SaveChanges();
        }
    }
}
