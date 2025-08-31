using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class EducationController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var educations = context.Educations.OrderByDescending(x => x.StartYear).ToList();
            return View(educations);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Education education)
        {
            if (!ModelState.IsValid)
            {
                return View(education);
            }

            context.Educations.Add(education);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Education added successfully!";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var education = context.Educations.Find(id);
            if (education == null)
            {
                return NotFound();
            }
            return View(education);
        }

        [HttpPost]
        public IActionResult Update(Education education)
        {
            if (!ModelState.IsValid)
            {
                return View(education);
            }

            context.Educations.Update(education);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Education updated successfully!";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var education = context.Educations.Find(id);
            if (education == null)
            {
                return NotFound();
            }

            context.Educations.Remove(education);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Education deleted successfully!";
            return RedirectToAction("Index");
        }
    }
}
