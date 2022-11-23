using ManchahatBooks.DataAccess.Repository.IRepository;
using ManchahatsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManchahatBooks.DataAccess.Repository
{
   public class UnitOfWork : IUnitOfWork// created public to access the class
    {
        private readonly ApplicationDbContext _db;      // using statement


        public UnitOfWork(ApplicationDbContext db)    // constructor to use inject in to repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryrepository Category { get; private set; }

        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void save()
        {
            _db.SaveChanges();
        }

        public void Save()
        {
            // throw new NotImplementedException();
        }
        
    }
}
