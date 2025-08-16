using System.ComponentModel.DataAnnotations;

namespace Portfolio.Web.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }

        [MinLength(5,ErrorMessage = "Project name must be at least 5 characters.")]
        [MaxLength(50,ErrorMessage = "The project name must be at most 5 characters.")]
        [Required(ErrorMessage = "Project name cannot be left blank.")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Project name cannot be left blank.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Project Image Url cannot be left blank.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Category cannot be left blank.")]
        public string GithubUrl { get; set; }

       

        public int CategoryId { get; set; }

        //navigation property
        public Category? Category { get; set; }
    }
}
