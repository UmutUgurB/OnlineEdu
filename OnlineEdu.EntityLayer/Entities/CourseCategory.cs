using System.ComponentModel.DataAnnotations;

namespace OnlineEdu.EntityLayer.Entities
{
    public class CourseCategory
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool CategoryIsActive { get; set; }
        public List<Course> Courses { get; set; }
    }
}
