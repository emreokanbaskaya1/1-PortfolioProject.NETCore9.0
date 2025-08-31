using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeaderComponent : ViewComponent 
    {
        private readonly PortfolioContext _context;

        public _AdminLayoutHeaderComponent(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.username = HttpContext.Session.GetString("UserName");
            
            // Session'dan UserId'yi al ve User model'ini bul
            var userId = HttpContext.Session.GetInt32("UserId");
            User user = null;
            
            if (userId.HasValue)
            {
                user = _context.Users.Find(userId.Value);
            }
            
            return View(user);
        }
    }
}
