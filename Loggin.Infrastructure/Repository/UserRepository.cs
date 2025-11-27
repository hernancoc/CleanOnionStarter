using Loggin.Application.Interfaces.Irepository;
using Loggin.Infrastructure.Context;
using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loggin.Domain.Entities;
namespace Loggin.Infrastructure.Repository
{
    internal class UserRepository: GenericRepository<Users>, IUserRepository
    {
        private readonly LogginContext _context;
        public UserRepository (LogginContext context) : base (context)
        {
            _context = context;
        }

        public async Task<string> IniciarSeccion(Users users)
        {
            var usuario = await _context.Users.FindAsync(users);
            if (usuario != null) {
                var pass = usuario.PassWord;
                var user = usuario.UserName;
                if (users.UserName == user && users.PassWord == pass) {

                    return "Acceso concedido";
                }
            }
            return "Acceso denegado";
        }
    }
}
