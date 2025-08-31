using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultHeroComponent(PortfolioContext context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            try
            {
                var banner = context.Banners.FirstOrDefault();
                return View(banner);
            }
            catch
            {
                return View();
            }
        }
    }
}
