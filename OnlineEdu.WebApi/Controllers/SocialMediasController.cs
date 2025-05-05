using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DTOLayer.DTOs.SocialMediaDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController(IGenericService<SocialMedia> genericService,IMapper mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSocialMediaList()
        {
            var values = genericService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetSocialMediaById(int id)
        {
            var value = genericService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            genericService.TDelete(id);
            return Ok("Silme İşlemi Başarıyla Gerçekleştirildi");
        }
        [HttpPut]
        public IActionResult EditSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var value = mapper.Map<SocialMedia>(updateSocialMediaDto);
            genericService.TUpdate(value);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMedia)
        {
            var value = mapper.Map<SocialMedia>(createSocialMedia);
            genericService.TAdd(value);
            return Ok("Social Media Ekleme İşlemi Başarıyla Gerçekleştirildi");
        }
    }

}
