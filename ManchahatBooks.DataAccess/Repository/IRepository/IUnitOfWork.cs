using System;
using System.Collections.Generic;
using System.Text;

namespace ManchahatBooks.DataAccess.Repository.IRepository
{
    interface IUnitOfWork : IDisposable
    {
        ICategoryrepository Category { get;  }

        ISP_Call SP_Call { get;  }
    }
}
