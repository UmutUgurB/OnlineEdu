using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DTOLayer.DTOs.SubscriberDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(IGenericService<Subscriber> _subscriberService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSubscribers()
        {
            var values = _subscriberService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _subscriberService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSubscribers(CreateSubscriberDtos createSubscriberDtos)
        {
            var value = _mapper.Map<Subscriber>(createSubscriberDtos);
            _subscriberService.TAdd(value);
            return Ok("Yeni Subscriber Oluşturma İşlemi Başarılı");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateSubscribers(UpdateSubscriberDtos updateSubscriberDtos)
        {
            var value = _mapper.Map<Subscriber>(updateSubscriberDtos);
            _subscriberService.TUpdate(value);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSubscriber(int id)
        {
            _subscriberService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");

        }

    }
}
