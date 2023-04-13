using Microsoft.AspNetCore.Mvc;
using ogreklesil.Models.Common;
using ogreklesil.Models.Repositories;
using System.Diagnostics;
using System.Text.Json;

namespace ogreklesil.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var a = new Student()
            //{
            //    Email = "121212",
            //    Name = "12121,",
            //    SurName="dsagf"
            //    Id = 1,
            //    PhoneNumber = "1234567890",
            //};
            //var list = new List<Student>() { a };
            //var jsonText = JsonSerializer.Serialize(list);
            
            //System.IO.File.WriteAllText("wwwroot//files//Ogrenciler.json", jsonText);

            

            var text = System.IO.File.ReadAllText("wwwroot//files//Ogrenciler.json");

            var list2 = System.Text.Json.JsonSerializer.Deserialize<List<Student>>(text);
 
            return View(list2);
        }

        public IActionResult Create()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}