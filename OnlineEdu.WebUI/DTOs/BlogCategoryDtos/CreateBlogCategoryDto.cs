using OnlineEdu.DTOLayer.DTOs.BlogDtos;
namespace OnlineEdu.WebUI.DTOs.BlogCategoryDtos
{
    public class CreateBlogCategoryDto
    {

        public string BlogCategoryName { get; set; }
        public bool BlogCategoryIsActive { get; set; }
        public List<ResultBlogDto> Blog { get; set; }
    }
}
