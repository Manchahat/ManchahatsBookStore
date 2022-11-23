using ManchahatBooks.DataAccess.Repository.IRepository;
using ManchahatsBookStore.DataAccess.Data;
using ManchahatBooks.Models;
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
            CoverType = new CoverTypeRepository(_db);
        }

        public ICategoryrepository Category { get; private set; }

        public ISP_Call SP_Call { get; private set; }


        public ICoverTypeRepository CoverType { get; private set; }

        //public ICoverTypeRepository CoverTypeRePository => throw new NotImplementedException();
        public void Dispose()
        {
            _db.Dispose();
        }

       public ICategoryrepository GetCoverType()
        {
            throw new NotImplementedException();
        }
      
        public void save()
        {
            _db.SaveChanges();  // changes will be saved 
        }

        public void Save()
        {
            // throw new NotImplementedException();
        }
        
    }
}
