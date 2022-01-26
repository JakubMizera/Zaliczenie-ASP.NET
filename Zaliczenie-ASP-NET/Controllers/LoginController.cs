using Microsoft.AspNetCore.Mvc;
using Zaliczenie_ASP_NET.Data;
using Zaliczenie_ASP_NET.Models;

namespace Zaliczenie_ASP_NET.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Login> objLoginList = _db.Login;
            return View(objLoginList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Login obj)
        {
            if (ModelState.IsValid)
            {
                _db.Login.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Profile created";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
