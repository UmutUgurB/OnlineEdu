using AutoMapper;
using OnlineEdu.DTOLayer.DTOs.BlogCategoryDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Mapping
{
    public class BlogCategoryMapping : Profile
    {
        public BlogCategoryMapping()
        {
            CreateMap<BlogCategory, ResultBlogCategoryDto>().ReverseMap();
            CreateMap<BlogCategory, UpdateBlogCategoryDto>().ReverseMap();
            CreateMap<BlogCategory, CreateBlogCategoryDto>().ReverseMap();

        }
    }
}
