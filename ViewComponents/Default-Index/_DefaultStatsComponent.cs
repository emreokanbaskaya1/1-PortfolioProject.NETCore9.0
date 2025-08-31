using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultStatsComponent(PortfolioContext context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.projectCount = context.Projects.Count();
            ViewBag.experienceYear = context.Experiences.Any() ? 
                DateTime.Now.Year - context.Experiences.Min(x => x.StartYear) : 0;
            ViewBag.companyCount = context.Experiences.Select(x => x.Company).Distinct().Count();
            ViewBag.skillsCount = context.Skills.Count();
            
            return View();
        }
    }
}
