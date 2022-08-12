using Microsoft.AspNetCore.Mvc;

namespace PhoneBookApp.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
