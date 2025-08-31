using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.Controllers
{
    [Authorize]
    public class StatisticsController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            ViewBag.projectCount = context.Projects.Count(); // Proje Sayısı
            ViewBag.skillsAverage = context.Skills.Any() ? context.Skills.Average(x=>x.Percentage).ToString("00.00") : 0.0.ToString("00.00");
            ViewBag.unreadMessageCount = context.UserMessages.Count(x => x.IsRead == false);
            ViewBag.lastMessageOwner = context.UserMessages.OrderByDescending(x => x.UserMessageId).Select(x=>x.Name).FirstOrDefault();

            var startYear = context.Experiences.Any() ? context.Experiences.Min(x => x.StartYear) : DateTime.Now.Year;
            
            ViewBag.experienceYear = DateTime.Now.Year - startYear;

            ViewBag.companyCount = context.Experiences.Select(x=>x.Company).Distinct().Count();

            ViewBag.reviewAverage = context.Testimonials.Any() ? context.Testimonials.Average(x => x.Review).ToString("0.0") : "No evaluation was made";

            ViewBag.maxReviewOwner = context.Testimonials.OrderByDescending(x => x.Review).Select(x => x.Name).FirstOrDefault();

            ViewBag.skillsCount = context.Skills.Count();

            ViewBag.educationCount = context.Educations.Count();

            ViewBag.messageCount = context.UserMessages.Count();




            ViewBag.highestSkillPercentage = context.Skills.Any() ? 
                context.Skills.Max(x => x.Percentage) : 0;

            return View(); 
        }
    }
}
