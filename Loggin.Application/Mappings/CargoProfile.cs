using Loggin.Application.Dtos;
using Loggin.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Loggin.Application.Mappings
{
    public class CargoProfile: Profile
    {
        public CargoProfile()
        {
            // Request → Entidad
            CreateMap<UserCreateDto, Users>();
            CreateMap<UserUpdateDto, Users>();

            // Entidad → Response
            CreateMap<Users, UserResponseDto>();
        }
    }
}
