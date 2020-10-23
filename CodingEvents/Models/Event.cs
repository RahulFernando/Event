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

        private static int NextId = 1;

        public Event(string name, string description)
        {
            Id = NextId;
            Name = name;
            Description = description;
            NextId++;
        }



        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            var @event = obj as Event;
            return @event != null &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
