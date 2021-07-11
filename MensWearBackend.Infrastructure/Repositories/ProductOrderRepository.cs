using MensWearBackend.Domain.Abstract;
using MensWearBackend.Domain.Entities;
using MensWearBackend.Infrastructure.Repositories.Base;

namespace MensWearBackend.Infrastructure.Repositories
{
    public class ProductOrderRepository : EntityBaseRepository<ProductOrder>, IProductOrderRepository
    {
        public ProductOrderRepository(ClothStoreDbContext context) : base(context) { }
    }
}
