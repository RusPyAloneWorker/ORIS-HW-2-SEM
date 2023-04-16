using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Core.Interfaces
{
    internal interface IUnitOfWork
    {
        Task<int> SaveChanges(CancellationToken token);
    }
}
