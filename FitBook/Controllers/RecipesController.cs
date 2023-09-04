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
        [HttpPost]
        public IActionResult Index(int? id)
        {
            Recipe? objToDelete = _db.Recipes.Find(id);
            _db.Recipes.Remove(objToDelete);
            _db.SaveChanges();
            return RedirectToAction("Index");   
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

        public IActionResult Recipe(Recipe obj)
        {
            Recipe? objToSee = _db.Recipes.Find(obj.Id);
            return View(objToSee);
        }
        public IActionResult Edit(int? id)
        {
            Recipe? objToEdit=_db.Recipes.Find(id);
            return View(objToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Recipe obj)
        {
            
            _db.Recipes.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
