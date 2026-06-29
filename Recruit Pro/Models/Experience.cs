namespace Recruit_Pro.Models
{
    public class Experience
    {
        public int experience_id { get; set; }
        public int position_id { get; set; }
        public int experience_years { get; set; }
        public string experience_area { get; set; }

        public Position Position { get; set; }
    }
}
