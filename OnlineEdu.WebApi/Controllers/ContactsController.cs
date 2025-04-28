using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DTOLayer.DTOs.ContactDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(IGenericService<Contact> _contactService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetList()
        {
            var values = _contactService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(UpdateContactDto updateContactDto)
        {
            var newValue = _mapper.Map<Contact>(updateContactDto);
            _contactService.TUpdate(newValue);
            return Ok("Editleme Başarılı");
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            var newValue = _mapper.Map<Contact>(createContactDto);
            _contactService.TAdd(newValue);
            return Ok("Başarıyla Oluşturuldu");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contactService.TDelete(id);
            return Ok("Başarılı Şekilde Silindi");
        }
    }
}
