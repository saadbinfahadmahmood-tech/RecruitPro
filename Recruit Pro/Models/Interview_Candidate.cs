namespace Recruit_Pro.Models
{
    public class Interview_Candidate
    {
        public int interview_id { get; set; }
        public string cnic { get; set; }
        public int application_id { get; set; }
        public int attendance_status { get; set; } // Points to lookup_id
        public string status { get; set; }
        public DateTime? hiring_date { get; set; }

        public Interview Interview { get; set; }
        public Candidate Candidate { get; set; }
        public Application Application { get; set; }
        public Lookup AttendanceStatusLookup { get; set; }
    }
}
