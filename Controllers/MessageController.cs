using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.Controllers
{
    public class MessageController(PortfolioContext context) : Controller
    {
        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            // Toplam mesaj sayısı
            var totalMessages = context.UserMessages.Count();

            // Toplam sayfa sayısı
            var totalPages = (int)Math.Ceiling((double)totalMessages / pageSize);

            // Sayfalama ile mesajları al
            var messages = context.UserMessages
                .OrderByDescending(x => x.UserMessageId) // En yeni mesajlar önce
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // ViewBag ile pagination bilgilerini gönder
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.TotalMessages = totalMessages;
            ViewBag.PageSize = pageSize;

            return View(messages);
        }

        public IActionResult MessageDelete(int id)
        {
            var message = context.UserMessages.Find(id);
            if (message == null)
            {
                return NotFound();
            }
            context.UserMessages.Remove(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ShowMessage(int id)
        {
            var message = context.UserMessages.FirstOrDefault(x => x.UserMessageId == id);
            
            if (message == null)
            {
                return NotFound();
            }
            
            // Mesajı okundu olarak işaretle
            message.IsRead = true;
            context.SaveChanges();
            
            // Partial view döndür (modal için)
            return PartialView("_MessageDetail", message);
        }
    }
}
