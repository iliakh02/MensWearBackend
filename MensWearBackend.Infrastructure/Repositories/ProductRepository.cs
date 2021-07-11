using MensWearBackend.Domain.Abstract;
using MensWearBackend.Domain.Entities;
using MensWearBackend.Infrastructure.Repositories.Base;

namespace MensWearBackend.Infrastructure.Repositories
{
    class ProductRepository: EntityBaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ClothStoreDbContext context): base(context)
        { }
    }
}
