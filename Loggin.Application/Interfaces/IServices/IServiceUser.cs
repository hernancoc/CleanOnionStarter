using AutoMapper.Configuration.Conventions;
using Loggin.Application.Dtos;
using Loggin.Application.Interfaces.Irepository;
using Loggin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggin.Application.Interfaces.IServices
{
    public interface IServiceUser
    {
        Task<IEnumerable<UserResponseDto>> GetAllAsync();
        Task<UserResponseDto> GetByIdAsync(int id);
        Task AddAsync(UserCreateDto dto);
        Task Update(UserUpdateDto dto);
        Task DeleteAsync(int id);
        Task<string> IniciarSeccion(UserResponseDto dto);

    }
}
