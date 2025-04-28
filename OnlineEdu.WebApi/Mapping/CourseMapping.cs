using AutoMapper;
using OnlineEdu.DTOLayer.DTOs.CourseDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Mapping
{
    public class CourseMapping:Profile
    {
        public CourseMapping()
        {
            CreateMap<ResultCourseDto, Course>().ReverseMap();
            CreateMap<UpdateCourseDto, Course>().ReverseMap();
            CreateMap<CreateCourseDto, Course>().ReverseMap();


        }
    }
}
