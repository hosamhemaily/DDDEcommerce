﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EcommerceDomain.Repos;
using EcommercePersistence.ProductManagment;

namespace EcommercePersistence
{
    public static class DI
    {
        public static IServiceCollection RegisterPersistence(this IServiceCollection services,string connectionString)
        {           
            services.AddDbContext<ProductContext>((serviceProvider,op) =>op.
            UseSqlServer(connectionString)
            );
            

            services.AddScoped<IrepoProduct, RepoProduct>();
            return services;
        }
    }
}
