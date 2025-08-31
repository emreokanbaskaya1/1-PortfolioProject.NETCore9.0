using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class ProfileController(PortfolioContext context) : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Session'dan UserId'yi al
            var userId = HttpContext.Session.GetInt32("UserId");
            
            if (!userId.HasValue)
            {
                return RedirectToAction("Login", "Auth");
            }
            
            var profile = context.Users.Find(userId.Value);
            
            if (profile == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            
            return View(profile);
        }

        [HttpPost]
        public IActionResult Index(User user, string currentPassword)
        {
            // Session'dan UserId'yi al
            var userId = HttpContext.Session.GetInt32("UserId");
            
            if (!userId.HasValue)
            {
                return RedirectToAction("Login", "Auth");
            }
            
            // Mevcut kullanıcıyı bul
            var existingUser = context.Users.Find(userId.Value);
            
            if (existingUser == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            // Mevcut şifre kontrolü
            if (string.IsNullOrEmpty(currentPassword) || existingUser.Password != currentPassword)
            {
                ModelState.AddModelError("", "The current password is wrong!");
                return View(existingUser);
            }

            // Sadece UserName ve Password'ü güncelle
            existingUser.UserName = user.UserName;
            existingUser.Password = user.Password;
            // FirstName ve LastName değiştirilmiyor
            
            context.Update(existingUser);
            context.SaveChanges();
            
            // Session'daki UserName'i de güncelle
            HttpContext.Session.SetString("UserName", user.UserName);
            return RedirectToAction("Index");
        }
    }
}
