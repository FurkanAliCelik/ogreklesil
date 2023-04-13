using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;
using ogreklesil.Models.Repositories;
using ogreklesil.Models.Common;

namespace ogreklesil.Controllers
{
    public class StudentsController : Controller
    {
        

        public StudentsController()
        {
            
        }
        [Route("deneme")]
        public IActionResult Index()
        {
            
        return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });





        }
        private static List<Student> students = new List<Student>();

            public IActionResult ındex()
            {
                return View(students);
            }

            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(Student student)
            {
                students.Add(student);
                return RedirectToAction("Index");
            }
        }
    }

