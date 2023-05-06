﻿using LoggerService;

namespace HSMD.WebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
            });
        }
        
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });
        }
        
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddScoped<LoggerManager, LoggerManager>();
        }

        public static void ConfigureRepository(this IServiceCollection services)
        {

        }
    }
}
