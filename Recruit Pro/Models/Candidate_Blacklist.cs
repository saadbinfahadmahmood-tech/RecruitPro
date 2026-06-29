namespace Recruit_Pro.Models
{
    public class Candidate_Blacklist
    {
        public int blacklist_id { get; set; }
        public string cnic { get; set; }
        public string reason { get; set; }
        public string blacklisted_by { get; set; }
        public DateTime blacklist_date { get; set; }

        public Candidate Candidate { get; set; }
        public Recruiter Recruiter { get; set; }
    }
}
