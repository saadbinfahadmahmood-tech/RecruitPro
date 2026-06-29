namespace Recruit_Pro.Models
{
    public class Candidate
    {
        public string cnic { get; set; }
        public string name { get; set; }
        public string father_name { get; set; }
        public int gender { get; set; } // Points to lookup_id
        public string domicile { get; set; }
        public string religion { get; set; }
        public DateTime dob { get; set; }
        public string email { get; set; }
        public string disability { get; set; }
        public string address { get; set; }
        public int? last_salary { get; set; }
        public int expected_salary { get; set; }
        public int status { get; set; } // Points to lookup_id
        public string comments { get; set; }

        public Lookup GenderLookup { get; set; }
        public Lookup StatusLookup { get; set; }
    }
}
