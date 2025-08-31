using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class BannerController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var banner = context.Banners.FirstOrDefault();
            return View(banner);
        }

        [HttpPost]
        public IActionResult Index(Banner banner)
        {
            if (!ModelState.IsValid)
            {
                return View(banner);
            }

            var existingBanner = context.Banners.FirstOrDefault();
            
            if (existingBanner == null)
            {
                // İlk kez oluştur
                context.Banners.Add(banner);
            }
            else
            {
                // Mevcut banner'ı güncelle
                existingBanner.CoverImageUrl = banner.CoverImageUrl;
                existingBanner.NameSurname = banner.NameSurname;
                existingBanner.Title = banner.Title;
                context.Banners.Update(existingBanner);
            }
            
            context.SaveChanges();
            TempData["SuccessMessage"] = "Banner updated successfully!";
            return RedirectToAction("Index", "Statistics");
        }
    }
}
