using Recruit_Pro.Models.enums__for_handling_lookups_;

namespace Recruit_Pro.Models
{
    public class Interviewer
    {
        public int interviewer_id { get; set; }
        public string name { get; set; } = null!;
        public string cnic { get; set; } = null!;
        public GenderType gender { get; set; } 
        public string designation { get; set; } = null!;
        public string department { get; set; } = null!;
        public string organization { get; set; } = null!;
        public DateTime hiring_date { get; set; }

        public List<string> cells { get; set; } = new List<string>();
        public List<Interview_Evaluation> Interview_Evaluations { get; set; } = new List<Interview_Evaluation>();
    }
}
