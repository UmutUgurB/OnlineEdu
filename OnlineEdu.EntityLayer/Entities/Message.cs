namespace OnlineEdu.EntityLayer.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public bool IsMessageActive { get; set; }
    }
}
