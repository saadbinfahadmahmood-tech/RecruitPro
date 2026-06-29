using Recruit_Pro.Models.enums__for_handling_lookups_;

namespace Recruit_Pro.Models
{
    public class Position
    {
        public int position_id { get; set; } 
        public string title { get; set; } = null!; 
        public string department { get; set; } = null!; 
        public string? description { get; set; } 
        public GenderType? gender { get; set; } 
        public string? responsibilities { get; set; } 
        public string? domicile { get; set; }
        public int? starting_salary { get; set; }
        public int? maximum_salary { get; set; } 
        public string? scale { get; set; } 
        public int? minimum_age { get; set; } 
        public int? maximum_age { get; set; } 
        public int status { get; set; } 
        public string? remarks { get; set; } 
    }
}
