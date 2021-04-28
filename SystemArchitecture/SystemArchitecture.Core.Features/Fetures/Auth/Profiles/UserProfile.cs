using SystemArchitecture.Core.Dto;
using SystemArchitecture.Core.Entities;
using SystemArchitecture.Core.Features.Fetures.Auth.Queries;
using AutoMapper;

namespace SystemArchitecture.Core.Features.Fetures.Auth.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User,UserDto>();
        }
    }
}