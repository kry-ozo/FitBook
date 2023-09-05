using FitBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBook.DataAccess.Repository.IRepository
{
    public interface IRecipeRepo : IRepository<Recipe>
    {
        void Update(Recipe recipe);
    }
}
