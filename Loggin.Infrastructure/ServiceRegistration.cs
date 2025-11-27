using Loggin.Application.Interfaces;
using Loggin.Application.Interfaces.Irepository;
using Loggin.Infrastructure.Context;
using Loggin.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Loggin.Infrastructure
{
    public static class ServiceRegistration
    {
       public static void addServiceInfraestructure(this IServiceCollection service, IConfiguration configuration)
       {

            service.AddDbContext<LogginContext>(options => options.UseSqlServer(configuration.GetConnectionString("conexion")));
            service.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            service.AddScoped<IUserRepository, UserRepository>();
       }


    }
}
