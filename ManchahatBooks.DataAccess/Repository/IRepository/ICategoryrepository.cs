using ManchahatBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManchahatBooks.DataAccess.Repository.IRepository
{
   public interface ICategoryrepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
