using Microsoft.EntityFrameworkCore;
using MyPortfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Core.Interfaces
{
    internal interface ICompanyRepository: IRepository<Company>
    {
        DbContext context { get; }
        DbSet<Company> companies { get; set; }

    }
}
