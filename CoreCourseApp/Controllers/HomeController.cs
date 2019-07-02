using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCourseApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreCourseApp.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db;
        public HomeController(DataContext _db)
        {
            db =_db;
        }

        [Authorize]
        public IActionResult Index()
        {
           //Models.Request model = new Models.Request();
           // model.Email = "ibrahim@gmail.com";
           // model.Message = "I want to join in this course";
           // model.Name = "İbrahim Aydin";
           // model.Phone = "0 544 742 19 93";
            return View();
        }
      
        [HttpGet]
        public IActionResult AddRequest()
        {
              return View();
        }
        [HttpPost]
        public IActionResult AddRequest(Request model)
        {
            db.Requests.Add(model);
            db.SaveChanges();
              return View("Thanks",model);
        }

        public IActionResult List()
        {
            return View(db.Requests.OrderBy(i => i.Name));
        }
        
    }
}