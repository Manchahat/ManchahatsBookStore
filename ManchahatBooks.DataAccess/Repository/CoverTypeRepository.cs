using ManchahatsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManchahatBooks.DataAccess.Repository
{
    class CoverTypeRepository
    {
        private ApplicationDbContext db;

        public CoverTypeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
    }
}
