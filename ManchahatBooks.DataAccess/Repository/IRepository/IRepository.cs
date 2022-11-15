using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ManchahatBooks.DataAccess.Repository.IRepository
{
   public interface IRepository<T> where T : class
    {
        T Get(int id); // retrieve a category from the database by id
        //list of categories based on eequirements

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null  // useful for forigen Key refrence
            );

        void Add(T entity);  // to add entity

        void Remove(int id); // to remove object 

        void Remove(T entity); // another way to remove object

        void RemoveRange(IEnumerable<T> entity); // remove a complete range of entity
    }
}
