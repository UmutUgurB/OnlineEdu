using OnlineEdu.DTOLayer.DTOs.BlogDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.DTOLayer.DTOs.BlogCategoryDtos
{
    public class CreateBlogCategoryDto
    {

        public string BlogCategoryName { get; set; }
        public bool BlogCategoryIsActive { get; set; }
        public List<ResultBlogDto> Blog { get; set; }
    }
}
