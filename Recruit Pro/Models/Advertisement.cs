namespace Recruit_Pro.Models
{
    public class Advertisement
    {
        public int advertisement_id { get; set; }
        public int position_id { get; set; }
        public string recruiter_id { get; set; }
        public DateTime posted_date { get; set; }
        public DateTime expiry_date { get; set; }
        public string ipl { get; set; }
        public string status { get; set; }

        public Position Position { get; set; }
        public Recruiter Recruiter { get; set; }
    }
}
