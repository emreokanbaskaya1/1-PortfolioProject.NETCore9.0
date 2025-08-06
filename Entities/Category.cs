namespace Portfolio.Web.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }

        public IList<Project> Projects { get; set; }


    }
}
