using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NguyensBooks.DataAccess.Repository.IRepository
{ 
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );
        void Add(T entity); // this adds an entity
        void Remove(int id); // removes an object or category
        void Remove(T entity); // a different way to remove an object
        void RemoveRange(IEnumerable<T> entity); // removes complete ranges of entities
    }
}
