using MensWearBackend.Domain.Abstract;
using MensWearBackend.Domain.Entities;
using MensWearBackend.Infrastructure.Repositories.Base;

namespace MensWearBackend.Infrastructure.Repositories
{
    public class OrderRepository: EntityBaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(ClothStoreDbContext context): base(context)
        { }
    }
}
