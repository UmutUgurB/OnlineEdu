using AutoMapper;
using OnlineEdu.DTOLayer.DTOs.BlogDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Mapping
{
    public class BlogMapping:Profile
    {
        public BlogMapping()
        {
            CreateMap<Blog, ResultBlogDto>().ReverseMap();
            CreateMap<Blog, CreateBlogDto>().ReverseMap();
            CreateMap<Blog, UpdateBlogDto>().ReverseMap();
        }
    }
}
