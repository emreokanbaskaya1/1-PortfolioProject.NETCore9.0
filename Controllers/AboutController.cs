using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class AboutController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var about = context.Abouts.FirstOrDefault();
            return View(about);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }

            var existingAbout = context.Abouts.FirstOrDefault();
            
            if (existingAbout == null)
            {
                // İlk kez oluştur
                context.Abouts.Add(about);
            }
            else
            {
                // Mevcut about'ı güncelle
                existingAbout.ImageUrl = about.ImageUrl;
                existingAbout.Title = about.Title;
                existingAbout.Description = about.Description;
                existingAbout.BirthDate = about.BirthDate;
                existingAbout.WebSite = about.WebSite;
                existingAbout.PhoneNumber = about.PhoneNumber;
                existingAbout.City = about.City;
                existingAbout.Graduation = about.Graduation;
                existingAbout.Email = about.Email;
                existingAbout.IsAvailable = about.IsAvailable;
                context.Abouts.Update(existingAbout);
            }
            
            context.SaveChanges();
            TempData["SuccessMessage"] = "About information updated successfully!";
            return RedirectToAction("Index", "Statistics");
        }
    }
}
