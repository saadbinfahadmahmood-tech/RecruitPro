using Recruit_Pro.Models.enums__for_handling_lookups_;

namespace Recruit_Pro.Models
{
    public class Candidate
    {
        public string cnic { get; set; } = null!;
        public string name { get; set; } = null!;
        public string father_name { get; set; } = null!;
        public GenderType gender { get; set; } 
        public string domicile { get; set; } = null!;
        public string religion { get; set; } = null!;
        public DateTime dob { get; set; }
        public string email { get; set; } = null!;
        public string disability { get; set; } = null!;
        public string address { get; set; } = null!;
        public int? last_salary { get; set; }
        public int expected_salary { get; set; }
        public CandidateStatus  status { get; set; } 
        public string comments { get; set; } = null!;

        public List<string> CandidateCell { get; set; } = new List<string>();
        public List<Candidate_Qualification> CandidateQualifications { get; set; } = new List<Candidate_Qualification>();
        public List<Candidate_Experience> CandidateExperiences { get; set; } = new List<Candidate_Experience>();
        public List<Application> CandiateApplications { get; set; } = new List<Application>();
        public List <Interview_Evaluation> CandidateInterviewsEvalutions { get; set; } = new List<Interview_Evaluation>();
        public List <Interview_Candidate> CandidateInterviews { get; set; } = new List<Interview_Candidate>();
    }
}
