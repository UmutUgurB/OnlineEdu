using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DTOLayer.DTOs.BannerDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IGenericService<Banner> _bannerService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBanners()
        {
            var values = _bannerService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBanner(CreateBannerDto createBannerDto)
        {
            var newValue = _mapper.Map<Banner>(createBannerDto);
            _bannerService.TAdd(newValue);
            return Ok("Banner Başarıyla Eklendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetBannerById(int id)
        {
            var value = _bannerService.TGetById(id);
            return Ok(value);

        }

        [HttpDelete]
        public IActionResult DeleteBanner(int id)
        {
            _bannerService.TDelete(id);
            return Ok("Başarıyla Silindi");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateBanner(UpdateBannerDto updateBannerDto)
        {
            var newValue = _mapper.Map<Banner>(updateBannerDto);
            _bannerService.TUpdate(newValue);
            return Ok("Güncelleme İşlemi Başarıyla Gerçekleştirildi.");
        }
    }

}