using Loggin.Application.Interfaces.Irepository;
using Loggin.Application.Interfaces.IServices;
using Loggin.Application.Mappings;
using Loggin.Application.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace Loggin.Application
{
    public static class ServiceRegistration
    {
        public static void addServiceApplication(this IServiceCollection services)
        {
            services.AddScoped<IServiceUser, ServiceUser>();
            services.AddAutoMapper(typeof(CargoProfile));
        }
    }
}
