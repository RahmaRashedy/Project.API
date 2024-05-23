using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL.Data.Context;
using ClassLibrary1.DAL.Repositorries.CartRepositorries;
using ClassLibrary1.DAL.Repositorries.OrderRepositorries;
using ClassLibrary1.DAL.Repositorries.ProductRepositorries;
using ClassLibrary1.DAL.Repositorries.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ClassLibrary1.DAL
{
   public static class ServicesExtensions
    {
        public static void AddDALService(this IServiceCollection service,IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("EcommeraceDb");
            service.AddDbContext<ProjectContext>(options =>
                options.UseSqlServer(connectionString));

            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped<IOrderRepository, OrderRepository>();
            service.AddScoped<ICartRepository, CartRepository>();

            service.AddScoped<IUnitOfWork, UnitOfWork>();

        }


    }
}
