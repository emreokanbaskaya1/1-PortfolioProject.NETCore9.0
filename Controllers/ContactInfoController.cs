using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class ContactInfoController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var contactInfo = context.ContactInfo.FirstOrDefault();
            return View(contactInfo);
        }

        [HttpPost]
        public IActionResult Index(ContactInfo contactInfo)
        {
            if (!ModelState.IsValid)
            {
                return View(contactInfo);
            }

            var existingContactInfo = context.ContactInfo.FirstOrDefault();
            
            if (existingContactInfo == null)
            {
                // İlk kez oluştur
                context.ContactInfo.Add(contactInfo);
            }
            else
            {
                // Mevcut contact info'yu güncelle
                existingContactInfo.Address = contactInfo.Address;
                existingContactInfo.PhoneNumber = contactInfo.PhoneNumber;
                existingContactInfo.Email = contactInfo.Email;
                existingContactInfo.MapUrl = contactInfo.MapUrl;
                context.ContactInfo.Update(existingContactInfo);
            }
            
            context.SaveChanges();
            TempData["SuccessMessage"] = "İletişim bilgileri başarıyla güncellendi!";
            return RedirectToAction("Index", "Statistics");
        }
    }
}
