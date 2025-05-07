namespace OnlineEdu.DTOLayer.DTOs.MessageDtos
{
    public class UpdateMessageDto
    {
        public int MessageID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public bool IsMessageActive { get; set; }
    }
}
