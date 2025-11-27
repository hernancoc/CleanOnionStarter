using Loggin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loggin.Domain.Entities;
namespace Loggin.Application.Interfaces.Irepository
{
    public interface IUserRepository:  IGenericRepository<Users>
    {
        Task<string>IniciarSeccion(Users users);
    }
}
