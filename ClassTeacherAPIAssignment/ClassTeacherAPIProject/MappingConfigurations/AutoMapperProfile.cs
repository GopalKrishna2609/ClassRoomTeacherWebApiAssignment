using ApiDbLayerTC.Entities;
using AutoMapper;
using ClassTeacherAPIProject.APImodel;

namespace ClassTeacherAPIProject.MappingConfigurations
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Teacher, TeacherApiModel>().ReverseMap(); ;
            CreateMap<ClassRoom, ClassRoomApiModel>().ReverseMap();
        }
    }
}
