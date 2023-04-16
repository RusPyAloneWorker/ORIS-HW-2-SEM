using Microsoft.EntityFrameworkCore;
using MyPortfolio.Core.Entities;
using MyPortfolio.Core.Interfaces;
using MyPortfolio.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Infastructure.Repository
{
    public class JobPositionRepository : IJobPositionRepository
    {
        private AppDbContext _appDbContext;

        public JobPositionRepository (
            AppDbContext appDbContext
            )
        {
            _appDbContext = appDbContext;
        }

        //public IQueryable<Company> JobPositions => throw new NotImplementedException();

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<JobPosition>> GetAll(CancellationToken token = default)
        {
            return await _appDbContext.Set<JobPosition>().ToArrayAsync();
        }

        public JobPosition GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(JobPosition obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(JobPosition obj)
        {
            throw new NotImplementedException();
        }
    }
}
