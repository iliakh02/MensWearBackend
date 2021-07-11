using MensWearBackend.Domain.Abstract;
using MensWearBackend.Domain.Entities;
using MensWearBackend.Infrastructure.Repositories.Base;

namespace MensWearBackend.Infrastructure.Repositories
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(ClothStoreDbContext context) : base(context) { }
    }
}
