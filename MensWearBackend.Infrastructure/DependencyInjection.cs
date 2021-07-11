using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensWearBackend.Domain.Abstract;

namespace MensWearBackend.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ClothStoreDbContext>(options =>
                       options.UseSqlServer(
                           configuration.GetConnectionString("DefaultConnection"),
                           b => b.MigrationsAssembly(typeof(ClothStoreDbContext).Assembly.FullName)));

            services.AddTransient<ICategoryRepository, CategoryRepository>();
            return services;
        }
    }
}
