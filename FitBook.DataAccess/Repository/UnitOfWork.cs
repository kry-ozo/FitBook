using FitBook.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBook.DataAccess.Repository
{
    internal class UnitOfWork : IUnitOfWork
    {
        public IRecipeRepo RecipeRepo => throw new NotImplementedException();

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
