using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Context
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {
        }

        //pluralize, singularize
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Education> Educations  { get; set; }
        public DbSet<Experience> Experiences  { get; set; }
        public DbSet<Project> Projects  { get; set; }

        //CRUD Create Read Update Delete
    }
}
