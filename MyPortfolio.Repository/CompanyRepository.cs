using Microsoft.EntityFrameworkCore;
using MyPortfolio.Core.Entities;
using MyPortfolio.Core.Interfaces;
using MyPortfolio.DataAccess.DataAccess;

namespace MyPortfolio.Infastructure.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        AppDbContext _dbContext;
        public CompanyRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbContext context => throw new NotImplementedException();

        public DbSet<Company> Companies { get { return _dbContext.Companies; } }

        //public IQueryable<Company> Companies { get { return _dbContext.Companies; } }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Company>> GetAll(CancellationToken token = default)
        {
            return await _dbContext.Set<Company>().ToArrayAsync();
        }

        public Company GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Company obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Company obj)
        {
            throw new NotImplementedException();
        }
    }
}