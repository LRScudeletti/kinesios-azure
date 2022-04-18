namespace KinesiOSAzureApi.Helpers;

using Entities;
using Models.Users;

using AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<User, CreateUser>();
    }
}