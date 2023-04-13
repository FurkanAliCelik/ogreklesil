using Microsoft.AspNetCore.Mvc;
using ogr.Data.Services;

namespace ogreklesil.Controllers
{
    public class AccountController : Controller
    {
        private readonly GirisService _girisService;
        public AccountController(GirisService girisService)
        {
            _girisService = girisService;
        }
        //[HttpGet("login")]
        public async Task<IActionResult> Login()
        {
           await  _girisService.Deneme();

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
