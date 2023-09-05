using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FitBook.DataAccess.Repository.IRepository
{
    public interface IRepository<O> where O : class
    {
        //O - object
        IEnumerable<O> GetAll(string? includePropertier = null);
        O Get(Expression<Func<O, bool>> filter, string? includePropertier = null);
        void Add(O entity);
        void Remove(O entity);
        void RemoveRange(IEnumerable<O> entities);
    }
}
