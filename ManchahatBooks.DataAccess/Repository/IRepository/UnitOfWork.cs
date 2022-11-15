using System;
using System.Collections.Generic;
using System.Text;

namespace ManchahatBooks.DataAccess.Repository.IRepository
{
    interface UnitOfWork : IDisposable
    {
        ICategoryrepository Category { get;  }

        ISP_Call SP_Call { get;  }
    }
}
