using Microsoft.AspNetCore.Mvc;
using PhoneBookApp.Data;
using PhoneBookApp.Models;
using System.Diagnostics;

namespace PhoneBookApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        /*public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }*/

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _db = db;
            _logger = logger;
        }

        /*public IActionResult Index()
        {
            
            
            return View();
        }*/

       public IActionResult Index()
        {
            string temp = TempData["userID"].ToString();
            int id = Convert.ToInt32(temp);
            IEnumerable<ContactDetail> contacts = _db.ContactDetails.Where(i => i.UserId == id).ToList();
            return View(contacts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}