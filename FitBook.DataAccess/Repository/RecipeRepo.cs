using FitBook.DataAccess.Repository.IRepository;
using FitBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBook.DataAccess.Repository
{
    public class RecipeRepo : Repository<Recipe>, IRecipeRepo
    {
        private ApplicationDbContext _db;
        public RecipeRepo(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Recipe obj)
        {
            _db.Recipes.Update(obj);
        }
    }
}
