using FitBook.DataAccess;
using FitBook.DataAccess.Repository.IRepository;
using FitBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;


namespace FitBook.Areas.User.Controllers
{
    [Area("User")]
    public class RecipesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public RecipesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Recipe> objListRecipe = (List<Recipe>)_unitOfWork.RecipeRepo.GetAll();
            return View(objListRecipe);
        }
        [HttpPost]
        public IActionResult Index(int? id)
        {
            Recipe? objToDelete = _unitOfWork.RecipeRepo.Get(u => u.Id == id);
            _unitOfWork.RecipeRepo.Remove(objToDelete);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Recipe obj)
        {
            _unitOfWork.RecipeRepo.Add(obj);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Recipe(Recipe obj)
        {
            Recipe? objToSee = _unitOfWork.RecipeRepo.Get(u => u.Id == obj.Id);
            return View(objToSee);
        }
        public IActionResult Edit(int? id)
        {
            Recipe? objToEdit = _unitOfWork.RecipeRepo.Get(u => u.Id == id);
            return View(objToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Recipe obj)
        {

            _unitOfWork.RecipeRepo.Update(obj);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
