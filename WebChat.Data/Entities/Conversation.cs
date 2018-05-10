using System;
using System.Collections.Generic;
using System.Text;

namespace WebChat.Data.Entities
{
    public class Conversation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Members { get; set; }
        public List<Message> Messages { get; set; }
        public DateTime LastChange { get; set; }
        public string Description { get; set; }
    }
}
