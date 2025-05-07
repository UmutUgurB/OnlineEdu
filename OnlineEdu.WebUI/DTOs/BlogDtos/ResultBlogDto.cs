

using OnlineEdu.WebUI.DTOs.BlogCategoryDtos;

namespace OnlineEdu.WebUI.DTOs.BlogDtos
{
    public class ResultBlogDto
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogImage { get; set; }
        public string BlogContent { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogIsActive { get; set; }
        public int BlogCategoryID { get; set; }
        public ResultBlogCategoryDto BlogCategory { get; set; }
    }
}
