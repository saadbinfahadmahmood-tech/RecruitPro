namespace Recruit_Pro.Models
{
    public class Interview
    {
        public int interview_id { get; set; }
        public int advertisement_id { get; set; }
        public string recruiter_id { get; set; }
        public DateTime interview_date { get; set; }

        public Advertisement Advertisement { get; set; }
        public Recruiter Recruiter { get; set; }
    }
}
