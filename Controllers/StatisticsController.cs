using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.Controllers
{
    public class StatisticsController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            ViewBag.projectCount = context.Projects.Count(); // Proje Sayısı
            ViewBag.skillsAverage = context.Skills.Any() ? context.Skills.Average(x=>x.Percentage).ToString("00.00") : 0.0.ToString("00.00");
            ViewBag.unreadMessageCount = context.UserMessages.Count(x => x.IsRead == false);
            ViewBag.lastMessageOwner = context.UserMessages.OrderByDescending(x => x.UserMessageId).Select(x=>x.Name).FirstOrDefault();
            return View(); 
        }
    }
}
