using ManchahatBooks.DataAccess.Repository.IRepository;
using System;
using ManchahatBooks.Models;
using System.Collections.Generic;
using System.Text;

namespace ManchahatBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
