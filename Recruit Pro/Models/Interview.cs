namespace Recruit_Pro.Models
{
    public class Interview
    {
        public int interview_id { get; set; }
        public DateTime interview_date { get; set; }
        public List<Interviewer> interviewers { get; set; } = new List<Interviewer>();
        public List<Interview_Candidate> CandidatesInterviews { get; set; } = new List<Interview_Candidate>();
        public List<Interview_Evaluation> InterviewEvaluations { get; set; } = new List<Interview_Evaluation>();
    }
}

