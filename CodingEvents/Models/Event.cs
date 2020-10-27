using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public EventType Type { get; set; }


        public Event()
        {

        }

        public Event(string name, string description, string email)
        {
            Name = name;
            Description = description;
            Email = email;
        }



        public override string ToString()
        {
            return Name;
        }

    }
}
