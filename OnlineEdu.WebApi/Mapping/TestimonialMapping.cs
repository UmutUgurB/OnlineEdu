using AutoMapper;
using OnlineEdu.DTOLayer.DTOs.SubscriberDtos;
using OnlineEdu.DTOLayer.DTOs.TestimonialDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Mapping
{
    public class TestimonialMapping : Profile

    {
        public TestimonialMapping()
        {
            CreateMap<CreateTestimonialDtos, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDtos, Subscriber>().ReverseMap();
            CreateMap<ResultTestimonialDtos, Subscriber>().ReverseMap();
        }
    }
}
