using AutoMapper;
using KinesiOSAzureApi.Entities;
using KinesiOSAzureApi.Models;

namespace KinesiOSAzureApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<Patient, PatientModel>();
            CreateMap<MedicalRecord, MedicalRecordModel>();
        }
    }
}