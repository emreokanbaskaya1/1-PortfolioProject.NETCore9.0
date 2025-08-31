using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class TestimonialController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var testimonials = context.Testimonials.OrderByDescending(x => x.TestimonialId).ToList();
            return View(testimonials);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Testimonial testimonial)
        {
            if (!ModelState.IsValid)
            {
                return View(testimonial);
            }

            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Testimonial added successfully!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var testimonial = context.Testimonials.Find(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            return View(testimonial);
        }

        [HttpPost]
        public IActionResult Update(Testimonial testimonial)
        {
            if (!ModelState.IsValid)
            {
                return View(testimonial);
            }

            context.Testimonials.Update(testimonial);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Testimonial updated successfully!";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var testimonial = context.Testimonials.Find(id);
            if (testimonial == null)
            {
                return NotFound();
            }

            context.Testimonials.Remove(testimonial);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Testimonial deleted successfully!";
            return RedirectToAction("Index");
        }
    }
}
