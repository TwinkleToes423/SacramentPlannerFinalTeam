using System;
using System.Collections.Generic;

namespace SacramentPlanner.Models
{
    public partial class Meeting
    {
        public int MeetingId { get; set; }
        public int SpeakerId { get; set; }
        public string Conductor { get; set; }
        public string OpeningHymn { get; set; }
        public string OpeningPrayer { get; set; }
        public string SacramentHymn { get; set; }
        public string IntermediateHymn { get; set; }
        public int ClosingHymn { get; set; }
        public int ClosingPrayer { get; set; }
        public DateTime Date { get; set; }

        public Speaker Speaker { get; set; }
    }
}
