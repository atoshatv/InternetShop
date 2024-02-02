using Domain.Enums;

namespace Domain.Models
{
    public class Chat
    {
        public Guid Id { get; set; }
        public ChatType Type { get; set; }  
        public string? Title { get; set; }
        public List<UserChat> Users { get; set; }
        public List<Message> Messages { get; set; }

        public Chat() 
        { 
            Messages = new List<Message>();
            Users = new List<UserChat>();
        }   
    }
}
