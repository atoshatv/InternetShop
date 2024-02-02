namespace Domain.Models
{
    public class UserChat
    {
        public Guid Id { get; set; }
        public User? User { get; set; }
        public Guid UserId { get; set; }
        public Chat? Chat { get; set; }
        public Guid ChatId { get; set; }
    }
}
