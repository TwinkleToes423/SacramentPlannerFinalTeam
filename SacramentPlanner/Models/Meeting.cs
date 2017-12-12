using System;
using System.Collections.Generic;

namespace SacramentPlanner.Models
{
    public enum Speakers
    {
        Bishop,
        First_Councilor,
        Second_Councilor,
        Other
    }

    public partial class Meeting
    {
        public int MeetingId { get; set; }
        public int SpeakerId { get; set; }
        public string Conductor { get; set; }
        public int OpeningHymn { get; set; }
        public string OpeningPrayer { get; set; }
        public int SacramentHymn { get; set; }
        public int IntermediateHymn { get; set; }
        public int ClosingHymn { get; set; }
        public string ClosingPrayer { get; set; }
        public DateTime Date { get; set; }

        public Speaker Speaker { get; set; }
    }
}
