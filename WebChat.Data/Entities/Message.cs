using System;

namespace WebChat.Data.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public User Author { get; set; }
        public DateTime SendDate { get; set; }
        public string Content { get; set; }
    }
}
