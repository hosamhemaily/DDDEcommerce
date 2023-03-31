using EcommerceContract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApplication.Application
{
    public static class DI
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddScoped<IProductAppService, ProductAppService>();
            services.AddScoped<IOrderAppService, OrderAppService>();
            services.AddScoped<IProductTransactionAppService, ProductTransactionAppService>();
            return services;
        }
    }
}
