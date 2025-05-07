using OnlineEdu.DTOLayer.DTOs.BlogDtos;
namespace OnlineEdu.WebUI.DTOs.BlogCategoryDtos
{
    public class UpdateBlogCategoryDto
    {
        public int BlogCategoryID { get; set; }
        public string BlogCategoryName { get; set; }
        public bool BlogCategoryIsActive { get; set; }
        public List<ResultBlogDto> Blog { get; set; }
    }
}
