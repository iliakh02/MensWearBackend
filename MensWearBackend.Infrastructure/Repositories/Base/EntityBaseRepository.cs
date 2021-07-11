using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensWearBackend.Domain.Abstract.Base;
using Microsoft.EntityFrameworkCore;

namespace MensWearBackend.Infrastructure.Repositories.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase
    {
        protected readonly ClothStoreDbContext _context;

        public EntityBaseRepository(ClothStoreDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
