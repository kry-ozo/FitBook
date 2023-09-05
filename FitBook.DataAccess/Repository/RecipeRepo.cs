using FitBook.DataAccess.Repository.IRepository;
using FitBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBook.DataAccess.Repository
{
    internal class RecipeRepo : Repository<Recipe>, IRecipeRepo
    {
        public void Update(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
