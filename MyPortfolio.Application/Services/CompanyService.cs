using MyPortfolio.Application.ServiceAbstractions;
using MyPortfolio.Core.Entities;
using MyPortfolio.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(
            ICompanyRepository companyRepository
            ) 
        {
            _companyRepository = companyRepository;
        }

        public async Task<IEnumerable<Company>> GetAll()
        {
            return  await _companyRepository.GetAll();
        }
    }
}
