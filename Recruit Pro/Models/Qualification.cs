namespace Recruit_Pro.Models
{
    public class Qualification
    {
        public int qualification_id { get; set; }
        public int position_id { get; set; }
        public int qualification_level { get; set; } // Points to lookup_id
        public string degree_area { get; set; }
        public string degree { get; set; }

        public Position Job_Position { get; set; }
        public Lookup QualificationLevelLookup { get; set; }
    }
}
