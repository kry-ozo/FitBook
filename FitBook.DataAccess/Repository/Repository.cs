using FitBook.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FitBook.DataAccess.Repository
{
    internal class Repository<O> : IRepository<O> where O : class
    {
        public void Add(O entity)
        {
            throw new NotImplementedException();
        }

        public O Get(Expression<Func<O, bool>> filter, string? includePropertier = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<O> GetAll(string? includePropertier = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(O entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<O> entities)
        {
            throw new NotImplementedException();
        }
    }
}
