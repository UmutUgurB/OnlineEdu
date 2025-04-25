namespace OnlineEdu.DTOLayer.DTOs.BannerDtos
{
    public class UpdateBannerDto
    {
        public int BannerID { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public bool BannerIsActive { get; set; }
    }
}
