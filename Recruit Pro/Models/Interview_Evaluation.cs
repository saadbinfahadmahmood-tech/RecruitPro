namespace Recruit_Pro.Models
{
    public class Interview_Evaluation
    {
        public int evaluation_id { get; set; }
        public int interview_id { get; set; }
        public string cnic { get; set; }
        public int interviewer_id { get; set; }
        public int evaluation_score_id { get; set; }
        public int remarks { get; set; } // Points to lookup_id
        public string comments { get; set; }
        public string status { get; set; }

        public Evaluation_Score Evaluation_Score { get; set; }
        public Lookup RemarksLookup { get; set; }
    }
}
