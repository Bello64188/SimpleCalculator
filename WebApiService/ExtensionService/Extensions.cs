using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiService.ExtensionService
{
    public static  class Extensions
    {
        public static void CORSConfiguration( this IServiceCollection services)
        {
            services.AddCors(option =>
            {
                option.AddPolicy("policy", op =>
                {
                    op.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                  
                });
            });
            services.AddCors(option =>
            {
                option.AddPolicy("specificpolicy", op =>
                {
                    op.WithOrigins("http://localhost:5001")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
                });
            });
        }
    }
}
