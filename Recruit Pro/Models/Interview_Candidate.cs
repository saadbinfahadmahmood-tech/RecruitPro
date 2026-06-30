using Recruit_Pro.Models.enums__for_handling_lookups_;
namespace Recruit_Pro.Models
{
    public class Interview_Candidate
    {
        public AttendanceStatus attendance_status { get; set; } 
        public string status { get; set; } = null!;
        public DateTime? hiring_date { get; set; }


    }
}
