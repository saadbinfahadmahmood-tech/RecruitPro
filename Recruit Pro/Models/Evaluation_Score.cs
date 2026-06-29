namespace Recruit_Pro.Models
{
    public class Evaluation_Score
    {
        public int evaluation_score_id { get; set; }
        public int interviewer_id { get; set; }
        public int qualification_marks { get; set; }
        public int experience_marks { get; set; }
        public int administrative_marks { get; set; }
        public int general_knowledge_marks { get; set; }
        public int physical_appearance_marks { get; set; }
        public int communication_marks { get; set; }

        public Interviewer Interviewer { get; set; }
    }
}
