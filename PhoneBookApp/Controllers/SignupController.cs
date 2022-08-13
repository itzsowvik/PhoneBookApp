using Microsoft.AspNetCore.Mvc;

namespace PhoneBookApp.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
