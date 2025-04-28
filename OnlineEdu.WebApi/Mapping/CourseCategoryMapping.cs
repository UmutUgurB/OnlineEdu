using AutoMapper;
using OnlineEdu.DTOLayer.DTOs.CourseCategoryDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Mapping
{
    public class CourseCategoryMapping:Profile
    {
        public CourseCategoryMapping()
        {
            CreateMap<CreateCourseCategoryDto, CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCategoryDto, CourseCategory>().ReverseMap();
            CreateMap<ResultCourseCategoryDto, CourseCategory>().ReverseMap();
        }
    }
}
