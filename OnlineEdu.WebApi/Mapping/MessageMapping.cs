using AutoMapper;
using OnlineEdu.DTOLayer.DTOs.MessageDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Mapping
{
    public class MessageMapping : Profile
    {
        public MessageMapping()
        {
            CreateMap<CreateMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();
        }
    }
}
