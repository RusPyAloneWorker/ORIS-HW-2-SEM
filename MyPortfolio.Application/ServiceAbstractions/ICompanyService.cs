using MyPortfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Application.ServiceAbstractions
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetAll();
    }
}
