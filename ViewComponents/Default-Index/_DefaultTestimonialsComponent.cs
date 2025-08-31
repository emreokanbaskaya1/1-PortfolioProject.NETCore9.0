using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultTestimonialsComponent(PortfolioContext context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var testimonials = context.Testimonials.OrderByDescending(x => x.TestimonialId).ToList();
            return View(testimonials);
        }
    }
}
