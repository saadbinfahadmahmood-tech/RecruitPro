using Recruit_Pro.Models.enums__for_handling_lookups_;

namespace Recruit_Pro.Models
{
    public class Interview_Evaluation
    {
        public int evaluation_id { get; set; }
        public EvaluationRemarks remarks { get; set; }
        public string comments { get; set; } = null!;
        public string status { get; set; } = null!;

        public Evaluation_Score score { get; set; } = new Evaluation_Score();

    }
}
