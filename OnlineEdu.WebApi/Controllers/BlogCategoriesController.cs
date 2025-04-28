using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DTOLayer.DTOs.BlogCategoryDtos;
using OnlineEdu.DTOLayer.DTOs.BlogDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoriesController(IGenericService<BlogCategory> blogCategory,IMapper _mapper) : ControllerBase
    {

        [HttpGet]
        public IActionResult GetBlogCategories()
        {
            var values = blogCategory.TGetListAll();
            return Ok(values);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var value = blogCategory.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult CreateBlogCategory(CreateBlogCategoryDto createBlogCategoryDto)
        {
            var newValue = _mapper.Map<BlogCategory>(createBlogCategoryDto);
            blogCategory.TAdd(newValue);
            return Ok("Blog Kategorisi Başarıyla Eklendi!");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBlogCategory(int id)
        {
            blogCategory.TDelete(id);
            return Ok("Blog Kategorisi Başarıyla Silindi");
        }
        [HttpPut("{id}")]
        public IActionResult Edit(UpdateBlogCategoryDto updateBlogCategoryDto)
        {
            var newValue = _mapper.Map<BlogCategory>(updateBlogCategoryDto);
            blogCategory.TUpdate(newValue);
            return Ok("Güncelleme başarılı!");
        }
    }
}
