using AutoMapper;
using Loggin.Application.Dtos;
using Loggin.Application.Interfaces.Irepository;
using Loggin.Application.Interfaces.IServices;
using Loggin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loggin.Application.Services
{
    public class ServiceUser : IServiceUser
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mmaper;
        public ServiceUser(IUserRepository repo,IMapper mapper)
        {
            _mmaper = mapper;
            _repo = repo;
        }

        public async Task AddAsync(UserCreateDto dto)
        {
            var entidad = _mmaper.Map<Users>(dto);
            await _repo.AddAsync(entidad);
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);                
        }

        public async Task<IEnumerable<UserResponseDto>> GetAllAsync()
        {
            var users = await _repo.GetAllAsync();
            return _mmaper.Map<List<UserResponseDto>>(users);

        }

        public async Task<UserResponseDto> GetByIdAsync(int id)
        {
            var users = await _repo.GetByIdAsync(id);
            return _mmaper.Map<UserResponseDto>(users);
        }

        public async Task<string> IniciarSeccion(UserResponseDto dto)
        {
            var users = _mmaper.Map<Users>(dto);
           return await _repo.IniciarSeccion(users);
        }

        public async Task Update(UserUpdateDto dto)
        {
            var users = _mmaper.Map<Users>(dto);
             await _repo.Update(users);
        }
    }
}
