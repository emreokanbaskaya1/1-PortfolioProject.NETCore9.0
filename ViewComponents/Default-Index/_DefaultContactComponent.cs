using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultContactComponent(PortfolioContext context): ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var contacts = context.ContactInfo.ToList();
            return View(contacts);
        }
    }
}
