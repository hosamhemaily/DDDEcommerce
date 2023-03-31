using EcommerceDomain.Products.MyProduct;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain
{
    public static class DI
    {
        public static IServiceCollection RegisterDomain(this IServiceCollection services)
        {
            services.AddScoped<IProductManager,ProductManager>();
            return services;
        }
    }
}
