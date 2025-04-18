namespace OnlineEdu.EntityLayer.Entities
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogImage { get; set; }
        public string BlogContent { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogIsActive { get; set; }
        public int BlogCategoryID { get; set; }
        public BlogCategory BlogCategory{ get; set; }
    }
}
