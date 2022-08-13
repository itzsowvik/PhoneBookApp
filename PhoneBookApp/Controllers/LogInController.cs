using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.Data;
using PhoneBookApp.Models;

namespace PhoneBookApp.Controllers
{
    public class LogInController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LogInController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get
        public IActionResult Index()
        {
            return View();
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User obj)
        {
            var UserInfo = _db.Users.FirstOrDefault(u=>u.UserName == obj.UserName && u.Password == obj.Password);
            if(UserInfo == null)
            {
                return View("~/Views/NotFound.cshtml");
            }
            TempData["userID"] = UserInfo.Id;
            return RedirectToAction("Index", "Home");
        }
    }
}
