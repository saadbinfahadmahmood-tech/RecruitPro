namespace Recruit_Pro.Models
{
    public class Interview_Interviewer
    {
        public int interview_id { get; set; }
        public int interviewer_id { get; set; }

        public Interview Interview { get; set; }
        public Interviewer Interviewer { get; set; }
    }
}
