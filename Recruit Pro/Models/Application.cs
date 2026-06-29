namespace Recruit_Pro.Models
{
    public class Application
    {
        public int application_id { get; set; }
        public int advertisement_id { get; set; }
        public string cnic { get; set; }
        public DateTime applied_date { get; set; }
        public string remarks { get; set; }
        public int? eligibility { get; set; } // Points to lookup_id
        public string comments_from_hr { get; set; }

        public Advertisement Advertisement { get; set; }
        public Candidate Candidate { get; set; }
        public Lookup EligibilityLookup { get; set; }
    }
}
