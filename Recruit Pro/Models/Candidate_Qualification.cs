namespace Recruit_Pro.Models
{
    public class Candidate_Qualification
    {
        public int cand_qual_id { get; set; }
        public string cnic { get; set; }
        public string degree_level { get; set; }
        public string institute { get; set; }
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }
        public string degree { get; set; }
        public decimal percentage { get; set; }
        public string division { get; set; }

        public Candidate Candidate { get; set; }
    }
}
