using FitBook.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IRecipeRepo RecipeRepo { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            RecipeRepo = new RecipeRepo(_db);
        }



        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
