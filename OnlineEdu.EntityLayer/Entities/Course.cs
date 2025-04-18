namespace OnlineEdu.EntityLayer.Entities
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseImage{ get; set; }
        public int CategoryID { get; set; }
        public CourseCategory Category { get; set; }

        public decimal Price { get; set; }
        public bool CourseIsActive { get; set; }


    }
}
