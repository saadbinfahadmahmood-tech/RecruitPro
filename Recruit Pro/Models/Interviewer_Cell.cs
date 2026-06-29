namespace Recruit_Pro.Models
{
    public class Interviewer_Cell
    {
        public int interviewer_id { get; set; }
        public string cell_number { get; set; }

        public Interviewer Interviewer { get; set; }
    }
}
