using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class SkillsController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {


            var skills = context.Skills.ToList();
            return View(skills);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("Index");

        }


        public IActionResult DeleteSkill(int id)
        {
            var skill = context.Skills.Find(id);
            if (skill == null)
            {
                return NotFound();
            }
            context.Skills.Remove(skill);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
         var skills = context.Skills.Find(id);
            if (skills == null)
            {
                return NotFound();
            }
            return View(skills);

        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            context.Skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
