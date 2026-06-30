namespace Recruit_Pro.Models
{
    public class Candidate_Experience
    {
        public int cand_exp_id { get; set; }
        public string designation { get; set; } = null!;
        public string organization { get; set; } = null!;
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }

    }
}
