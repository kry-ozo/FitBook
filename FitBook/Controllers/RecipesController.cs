using FitBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace FitBook.Controllers
{
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RecipesController(ApplicationDbContext db) {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Recipe> objListRecipe = _db.Recipes.ToList();
            return View(objListRecipe);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Recipe obj)
        {
            _db.Recipes.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
