using Microsoft.AspNetCore.Http;
using AutoMapper;
using Dogs.Api.Models;
using Dogs.Api.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Dogs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreedsController : Controller
    {
        private static Breed[] _breeds = DataSeeder.breeds; 
        IMapper _mapper;
         public BreedsController(IMapper mapper) 
         {
            _mapper= mapper;
         }

        [HttpGet]
        public IEnumerable<Breed> Get() 
        {
            return _breeds;
        }
    }
}
