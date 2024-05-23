using ClassLibrary1.BL.Manager.Cart;
using ClassLibrary1.BL.Manager.Order;
using ClassLibrary1.BL.Manager.Product;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BL
{
    public static class ServiceExtensions
    {
        public static void AddBLServices(this IServiceCollection services)
        {
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<IcartManager, CartManager>();
            services.AddScoped<IOrderManager, OrderManager>();
        }
    }
}
