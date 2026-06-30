namespace Recruit_Pro.Models
{
    public class Qualification
    {
        public int qualification_id { get; set; }
        public int position_id { get; set; }
        public int qualification_level { get; set; }
        public string degree_area { get; set; } = null!;
        public string degree { get; set; } = null!;
    }
}
