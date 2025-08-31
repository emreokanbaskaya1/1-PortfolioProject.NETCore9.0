using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class ExperienceController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var experiences = context.Experiences.OrderByDescending(x => x.StartYear).ToList();
            return View(experiences);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                return View(experience);
            }

            context.Experiences.Add(experience);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Experience added successfully!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var experience = context.Experiences.Find(id);
            if (experience == null)
            {
                return NotFound();
            }
            return View(experience);
        }

        [HttpPost]
        public IActionResult Update(Experience experience)
        {
            if (!ModelState.IsValid)
            {
                return View(experience);
            }

            context.Experiences.Update(experience);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Experience updated successfully!";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var experience = context.Experiences.Find(id);
            if (experience == null)
            {
                return NotFound();
            }

            context.Experiences.Remove(experience);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Experience deleted successfully!";
            return RedirectToAction("Index");
        }
    }
}
