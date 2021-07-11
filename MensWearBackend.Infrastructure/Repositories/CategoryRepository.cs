using MensWearBackend.Domain.Abstract;
using MensWearBackend.Domain.Entities;
using MensWearBackend.Infrastructure.Repositories.Base;

namespace MensWearBackend.Infrastructure.Repositories
{
    public class CategoryRepository: EntityBaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ClothStoreDbContext context): base(context)
        { }
    }
}
