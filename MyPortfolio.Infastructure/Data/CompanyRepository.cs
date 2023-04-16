using Microsoft.EntityFrameworkCore;
using MyPortfolio.Core.Entities;
using MyPortfolio.Core.Interfaces;

namespace MyPortfolio.Infastructure.Data
{
    public class CompanyRepository : ICompanyRepository
    {
        DbContext _dbContext;
        DbSet<Company> _companySet;
        public CompanyRepository(DbContext dbContext, DbSet<Company> companySet)
        {
            _dbContext = dbContext;
            _companySet = companySet;
        }

        public DbContext context => throw new NotImplementedException();

        public DbSet<Company> companies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Company>> GetAll(CancellationToken token = default)
        {
            throw new NotImplementedException();
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