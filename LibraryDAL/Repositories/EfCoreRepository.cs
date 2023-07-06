using LibraryDAL.DataContext;
using LibraryDAL.Entities;
using LibraryDAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace LibraryDAL.Repositories
{
    public class EfCoreRepository<T> : IRepositoryAsync<T> where T : Entity
    {
        private readonly AppDbContext _dbContext;

        public EfCoreRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            var result = await _dbContext.Set<T>().AddAsync(entity);

            await _dbContext.SaveChangesAsync();

            return result.Entity;
        }

        public virtual async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);

            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<ICollection<T>> GetAllAsync()
        {
            var result = await _dbContext.Set<T>().AsNoTracking().ToListAsync();

            return result;
        }

        public virtual async Task<T> GetByIdAsync(int? id)
        {
            var result = await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            var result = _dbContext.Set<T>().Update(entity);

            await _dbContext.SaveChangesAsync();

            return result.Entity;
        }
    }
}
