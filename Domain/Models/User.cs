namespace Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public List<UserChat>? Chats { get; set; }
        public string? Name { get; set; }
        public string? Avatar { get; set; }
        public bool Online { get; set; }
    }
}
