namespace Recruit_Pro.Models
{
    public class Advertisement
    {
        public int advertisement_id { get; set; }
        public DateTime posted_date { get; set; }
        public DateTime expiry_date { get; set; }
        public string ipl { get; set; } = null!;
        public string status { get; set; } = null!;
        public List<Application> Applications { get; set; } = new List<Application>();
        public List<Interview> Interviews { get; set; } = new List<Interview>();
    }
}
