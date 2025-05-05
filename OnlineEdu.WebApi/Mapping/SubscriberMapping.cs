using AutoMapper;
using OnlineEdu.DTOLayer.DTOs.SubscriberDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Mapping
{
    public class SubscriberMapping:Profile
    {
        public SubscriberMapping()
        {
            CreateMap<CreateSubscriberDtos, Subscriber>().ReverseMap();
            CreateMap<UpdateSubscriberDtos, Subscriber>().ReverseMap();
        }
    }
}
