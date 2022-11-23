using System;
using System.Collections.Generic;
using System.Text;

namespace ManchahatBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryrepository Category { get;  }

        ISP_Call SP_Call { get;  }
        ICoverTypeRepository CoverType { get; }

        void Save();
    }
}
