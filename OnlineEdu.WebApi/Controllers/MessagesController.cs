using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DTOLayer.DTOs.CourseDtos;
using OnlineEdu.DTOLayer.DTOs.MessageDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController(IGenericService<Message> _messageService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessages()
        {
            var values = _messageService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMessage(CreateMessageDto createMessageDto)
        {
            var newValue = _mapper.Map<Message>(createMessageDto);
            _messageService.TAdd(newValue);
            return Ok("Mesaj Başarıyla Eklendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetMessageById(int id)
        {
            var value = _messageService.TGetById(id);
            return Ok(value);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            _messageService.TDelete(id);
            return Ok("Başarıyla Silindi");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBanner(UpdateMessageDto updateMessageDto)
        {
            var newValue = _mapper.Map<Message>(updateMessageDto);
            _messageService.TUpdate(newValue);
            return Ok("Güncelleme İşlemi Başarıyla Gerçekleştirildi.");
        }
    }
}
