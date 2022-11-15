using ManchahatBooks.DataAccess.Repository.IRepository;
using ManchahatBooks.Models;
using ManchahatsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManchahatBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryrepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {    // uused .net LINQ to retrive the first or default category object then pass the id as a generic entity

            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)

            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
            

}
}
