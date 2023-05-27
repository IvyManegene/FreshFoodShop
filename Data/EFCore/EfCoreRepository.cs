using Microsoft.EntityFrameworkCore;

namespace FreshFoodShop.Data.Repositories
{
    public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext Context;
        public EfCoreRepository(TContext Context)
        {
            this.Context = Context;
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            await Context.SaveChangesAsync();
            return entity;
        }
        public  async Task<TEntity?> Delete(int id)
        {
            var Entity = await Context.Set<TEntity>().FindAsync(id);

            if (Entity == null)
            {
                return Entity;
            }
            Context.Set<TEntity>().Remove(Entity);
            await Context.SaveChangesAsync();
            return Entity;
        }
        public async Task<TEntity?> Get(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }
        public async Task<List<TEntity>> GetAll()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }
        public async Task<TEntity> Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return entity;
        }
    }
}
