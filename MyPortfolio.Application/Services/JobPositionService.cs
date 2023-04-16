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
    public class JobPositionService : IJobPositionService
    {
        public IJobPositionRepository _jobPositionRepository;

        public JobPositionService (
                IJobPositionRepository jobPositionRepository
            ) 
        {
            _jobPositionRepository = jobPositionRepository;
        }
        public async Task<IEnumerable<JobPosition>> GetAll()
        {
            return await _jobPositionRepository.GetAll();
        }
    }
}
