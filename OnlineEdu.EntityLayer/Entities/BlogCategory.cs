namespace OnlineEdu.EntityLayer.Entities
{
    public class BlogCategory
    {
        public int BlogCategoryID { get; set;}
        public string BlogCategoryName { get; set; }
        public bool BlogCategoryIsActive { get; set; }
        public List<Blog> Blog { get; set; }
    }
}
