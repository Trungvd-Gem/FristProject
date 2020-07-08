using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FristProject.Models;

namespace FristProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("myView");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // register
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Register(Student student)
        {
            //if (ModelState.IsValid)
            //{
                Repository.AddStudent(student);
                return View("Thanks", student);

            //} else
            //{
                return View();
            //}
        }

        // StudentList
        public IActionResult StudentList()
        {
            return View(Repository.GetStudents());
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
