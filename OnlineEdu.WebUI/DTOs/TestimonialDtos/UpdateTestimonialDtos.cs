namespace OnlineEdu.DTOLayer.DTOs.TestimonialDtos
{
    public class UpdateTestimonialDtos
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Comment { get; set; }
        public int Star { get; set; }
        public bool TestimonialIsActive { get; set; }
    }
}
