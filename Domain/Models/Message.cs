namespace Domain.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Text { get; set; }
        public Message()
        {

        }
        public Message(Guid id, string? text = null)
        {
            UserId = id;
            Text = text;
        }
    }
}
