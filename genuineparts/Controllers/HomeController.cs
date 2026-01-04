using Microsoft.AspNetCore.Mvc;
using genuineparts.Data;
using genuineparts.Models;

namespace genuineparts.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Users/Page
        public IActionResult Page()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        // GET: /Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Page");
            }
            return View(user);
        }
    }

    // ---------------------------------------
    //              HOME CONTROLLER
    // ---------------------------------------

    public class HomeController : Controller
    {
        // GET: /
        public IActionResult Index()
        {
            return View();
        }
        
    }
}