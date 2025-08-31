using Portfolio.Web.Entities;

namespace Portfolio.Web.Models
{
    public class ResumeViewModel
    {
        public List<Education> Educations { get; set; } = new List<Education>();
        public List<Experience> Experiences { get; set; } = new List<Experience>();
    }
}
