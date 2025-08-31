using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Models;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultResumeComponent(PortfolioContext context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var educations = context.Educations.OrderByDescending(x => x.StartYear).ToList();
            var experiences = context.Experiences.OrderByDescending(x => x.StartYear).ToList();
            
            var model = new ResumeViewModel
            {
                Educations = educations,
                Experiences = experiences
            };
            
            return View(model);
        }
    }
}
