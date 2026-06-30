using Recruit_Pro.Models.enums__for_handling_lookups_;
namespace Recruit_Pro.Models
{
    public class Application
    {
        public int application_id { get; set; }
        public DateTime applied_date { get; set; }
        public string? remarks { get; set; }
        public ApplicationEligibility? eligibility { get; set; }
        public string? comments_from_hr { get; set; } 
    }
}
