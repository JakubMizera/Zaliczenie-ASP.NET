using Microsoft.AspNetCore.Mvc;
using Zaliczenie_ASP_NET.Data;
using Zaliczenie_ASP_NET.Models;

namespace Zaliczenie_ASP_NET.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Products> objProductsList = _db.Products;
            return View(objProductsList);
        }
    }
}
