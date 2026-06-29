namespace Recruit_Pro.Models
{
    public class Interviewer
    {
        public int interviewer_id { get; set; }
        public string name { get; set; }
        public string cnic { get; set; }
        public int gender { get; set; } // Points to lookup_id
        public string designation { get; set; }
        public string department { get; set; }
        public string organization { get; set; }
        public DateTime hiring_date { get; set; }

        public Lookup GenderLookup { get; set; }
    }
}
