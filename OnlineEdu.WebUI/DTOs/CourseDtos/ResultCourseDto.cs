using OnlineEdu.DTOLayer.DTOs.CourseCategoryDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.DTOLayer.DTOs.CourseDtos
{
    public class ResultCourseDto
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseImage { get; set; }
        public int CategoryID { get; set; }
        public ResultCourseCategoryDto Category { get; set; }

        public decimal Price { get; set; }
        public bool CourseIsActive { get; set; }
    }
}
