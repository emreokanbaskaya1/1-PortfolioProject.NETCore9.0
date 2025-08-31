namespace Portfolio.Web.Entities
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string Title { get; set; }
        public int StartYear { get; set; }
        public int? StartMonth { get; set; } = 1; // Varsayılan olarak Ocak
        public string? EndYear { get; set; }
        public int? EndMonth { get; set; } = 12; // Varsayılan olarak Aralık
        public string Company { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
    }
}
