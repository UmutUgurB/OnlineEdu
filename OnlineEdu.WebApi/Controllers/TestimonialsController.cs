using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DTOLayer.DTOs.TestimonialDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IGenericService<Testimonial> _testimonialService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _testimonialService.TGetListAll();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GeyById(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);

        }
        [HttpPut("{id}")]
        public IActionResult UpdateTestimonialas(UpdateTestimonialDtos updateTestimonialDtos)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialDtos);
            _testimonialService.TUpdate(value);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            _testimonialService.TDelete(id);
            return Ok("Silme İşlemi Başarılı");
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDtos createTestimonialDtos)
        {
            var value = _mapper.Map<Testimonial>(createTestimonialDtos);
            _testimonialService.TAdd(value);
            return Ok("Ekleme İşlemi Başarılı");
        }
    }
}
