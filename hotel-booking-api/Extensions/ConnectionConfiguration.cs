using hotel_booking_data.Contexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace hotel_booking_api.Extensions
{
    public static class ConnectionConfiguration
    {

        public static void AddDbContextAndConfigurations(this IServiceCollection services, IWebHostEnvironment env, IConfiguration config)
        {
            services.AddDbContextPool<HbaDbContext>(options =>
            {
                string connStr;
/*
                if (env.IsProduction())
                {
                    connStr = GetHerokuConnectionString();
                }
                else
                {*/
                    connStr = config.GetConnectionString("PostgresConnectionString");
                
                options.UseNpgsql(connStr);
            });
        }
    }
}
