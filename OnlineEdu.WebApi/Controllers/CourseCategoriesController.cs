using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DTOLayer.DTOs.CourseCategoryDtos;
using OnlineEdu.DTOLayer.DTOs.CourseDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController(IGenericService<CourseCategory> _courseCategoryService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCourseCategory()
        {
            var values = _courseCategoryService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddCourseCategory(CreateCourseCategoryDto createCourseCategoryDto)
        {
            var newValue = _mapper.Map<CourseCategory>(createCourseCategoryDto);
            _courseCategoryService.TAdd(newValue);
            return Ok("Kurs Başarıyla Eklendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetBannerById(int id)
        {
            var value = _courseCategoryService.TGetById(id);
            return Ok(value);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBanner(int id)
        {
            _courseCategoryService.TDelete(id);
            return Ok("Başarıyla Silindi");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBanner(UpdateCourseCategoryDto updateCourseCategoryDto)
        {
            var newValue = _mapper.Map<CourseCategory>(updateCourseCategoryDto);
            _courseCategoryService.TUpdate(newValue);
            return Ok("Güncelleme İşlemi Başarıyla Gerçekleştirildi.");
        }
    }
}
