using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DTOLayer.DTOs.BannerDtos;
using OnlineEdu.DTOLayer.DTOs.CourseDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(IGenericService<Course> _courseService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCourse()
        {
            var values = _courseService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddCourse(CreateCourseDto createCourseDto)
        {
            var newValue = _mapper.Map<Course>(createCourseDto);
            _courseService.TAdd(newValue);
            return Ok("Kurs Başarıyla Eklendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetBannerById(int id)
        {
            var value = _courseService.TGetById(id);
            return Ok(value);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBanner(int id)
        {
            _courseService.TDelete(id);
            return Ok("Başarıyla Silindi");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBanner(UpdateCourseDto updateCourseDto)
        {
            var newValue = _mapper.Map<Course>(updateCourseDto);
            _courseService.TUpdate(newValue);
            return Ok("Güncelleme İşlemi Başarıyla Gerçekleştirildi.");
        }
    }
}
