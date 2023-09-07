using FitBook.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FitBook.DataAccess.Repository
{
    public class Repository<O> : IRepository<O> where O : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<O>? dbSet; 
        public Repository(ApplicationDbContext db) {
            _db= db;
            this.dbSet = _db.Set<O>();
        }
        public void Add(O entity)
        {
            dbSet.Add(entity);
        }

        public O Get(Expression<Func<O, bool>> filter, string? includePropertier = null)
        {
            IQueryable<O> query = dbSet;
            query = query.Where(filter);

            if (!string.IsNullOrEmpty(includePropertier))
            {
                foreach (var includeProp in includePropertier
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            return query.FirstOrDefault();
        }

        public IEnumerable<O> GetAll(string? includePropertier = null)
        {
            IQueryable<O> query = dbSet;


            if (!string.IsNullOrEmpty(includePropertier))
            {
                foreach (var includeProp in includePropertier
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            return query.ToList();
        }

        public void Remove(O entity)
        {
            dbSet?.Remove(entity);
        }

        public void RemoveRange(IEnumerable<O> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
