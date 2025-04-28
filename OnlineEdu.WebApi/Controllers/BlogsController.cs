using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DTOLayer.DTOs.BlogDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IGenericService<Blog> _blogService , IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBlogs()
        {
            var values = _blogService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = _blogService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult CreateBlog(CreateBlogDto createBlogDto)
        {
            var newValue = _mapper.Map<Blog>(createBlogDto);
            _blogService.TAdd(newValue);
            return Ok("Blog Başarıyla Eklendi!");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            _blogService.TDelete(id);
            return Ok("Blog Başarıyla Silindi");
        }
        [HttpPut("{id}")]
        public IActionResult Edit(UpdateBlogDto updateBlogDto)
        {
            var newValue = _mapper.Map<Blog>(updateBlogDto);
            _blogService.TUpdate(newValue);
            return Ok("Güncelleme başarılı!");
        }


    }
}
