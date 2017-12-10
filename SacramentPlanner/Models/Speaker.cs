using System;
using System.Collections.Generic;

namespace SacramentPlanner.Models
{
    public partial class Speaker
    {
        public Speaker()
        {
            Meeting = new HashSet<Meeting>();
        }

        public int SpeakerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Subject { get; set; }

        public ICollection<Meeting> Meeting { get; set; }
    }
}
