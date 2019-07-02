using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreCourseApp.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepository repo;

        public CourseController(ICourseRepository _repo)
        {
            repo = _repo;
        }
        public IActionResult Index(string name=null,decimal? price=null,string isActive=null)
        {
            Console.Clear();
            var courses = repo.GetCourseByFilters(name, price, isActive);
            ViewBag.Name = name;
            ViewBag.Price = price;
            ViewBag.isActive = isActive == "on" ? true:false;
            return View(courses);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.ActionMode = "Edit";
            return View(repo.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(Course entity,Course original)
        {
            repo.UpdateCourse(entity, original);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            ViewBag.ActionMode = "Create";
            return View("Edit", new Course());
        }

        [HttpPost]
        public IActionResult Create(Course newCourse)
        {
            int id = repo.CreateCourse(newCourse);
            Console.WriteLine("Id : {0}", id);
           return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Console.Clear();
            repo.DeleteCourse(id);
            return RedirectToAction("Index");
        }
    }
}