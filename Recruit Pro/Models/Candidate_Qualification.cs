namespace Recruit_Pro.Models
{
    public class Candidate_Qualification
    {
        public int cand_qual_id { get; set; }
        public string degree_level { get; set; } = null!;
        public string institute { get; set; } = null!;
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }
        public string degree { get; set; } = null!;
        public decimal percentage { get; set; }
        public string division { get; set; } = null!;

    }
}
