using MensWearBackend.Domain.Abstract.Base;
using MensWearBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensWearBackend.Domain.Abstract
{
    public interface ICartRepository : IEntityBaseRepository<CartItem> { }
    public interface ICategoryRepository : IEntityBaseRepository<Category> { }
    public interface IOrderRepository : IEntityBaseRepository<Order> { }
    public interface IProductOrderRepository : IEntityBaseRepository<ProductOrder> { }
    public interface IProductRepository : IEntityBaseRepository<Product> { }
    public interface IUserRepository : IEntityBaseRepository<User> { }
}
