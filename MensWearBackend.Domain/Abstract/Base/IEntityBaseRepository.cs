using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensWearBackend.Domain.Abstract.Base
{
    public interface IEntityBaseRepository<T> where T: class, IEntityBase
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task CommitAsync();
    }
}
