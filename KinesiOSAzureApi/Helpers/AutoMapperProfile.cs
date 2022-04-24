using KinesiOSAzureApi.Models;

namespace KinesiOSAzureApi.Helpers;

using Entities;
using AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<User, UserModel>();
    }
}