﻿using MarketIO.MVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MarketIO.MVC.Instrallers
{
    public class LifeCyclesInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IBrandRepository, BrandRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
       
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
        }
    }
}
