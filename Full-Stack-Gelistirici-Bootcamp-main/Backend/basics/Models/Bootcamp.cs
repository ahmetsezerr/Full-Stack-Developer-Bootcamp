namespace basics.Models
{

    public class Bootcamp
    {
        public int id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool isActive { get; set; }
        public bool isHome { get; set; }

    }
}