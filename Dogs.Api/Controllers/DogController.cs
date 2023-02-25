using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Dogs.Api.Models;
using Dogs.Api.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dogs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : Controller
    {
        private IMapper _mapper;
        private List<Dog> _dogs = DataSeeder.dogs;

        public DogController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<DogViewModel> GetDogs()
        {
            var dogView = _dogs.Select(x => _mapper.Map<Dog, DogViewModel>(x));

            return dogView;
        }

        [HttpGet("{page}/{count}/params")]
        public IEnumerable<DogViewModel> GetDogsByParams(
            int page,
            int count,
            [FromQuery] string breed=null,
            [FromQuery] int heightFrom=0,
            [FromQuery] int heightTo=999,
            [FromQuery] int weightFrom=0,
            [FromQuery] int weightTo=999,
            [FromQuery] int ageFrom=0,
            [FromQuery] int ageTo=999
            )
        {
            var dogs = _dogs.Where(x => x.MaxHeight >= heightFrom && x.MaxHeight <= heightTo)
                            .Where(x => x.MaxHeight >= weightFrom && x.MaxHeight <= weightTo)
                            .Where(x => x.MaxHeight >= ageFrom && x.MaxHeight <= ageTo);

            if (breed is not null)
            {
                dogs = dogs.Where(x=>x.Breed.Name==breed);
            }

            var result = dogs.Skip((page - 1) * count).Take(count).Select(x => _mapper.Map<Dog, DogViewModel>(x));

            return result;
        }
        [HttpGet("count")]
        public int GetCount() => _dogs.Count;

        [HttpGet("count/params")]
        public int GetCountParams(
            [FromQuery] string breed = null,
            [FromQuery] int heightFrom = 0,
            [FromQuery] int heightTo = 999,
            [FromQuery] int weightFrom = 0,
            [FromQuery] int weightTo = 999,
            [FromQuery] int ageFrom = 0,
            [FromQuery] int ageTo = 999
            )
        {
            var dogs = _dogs.Where(x => x.MaxHeight >= heightFrom && x.MaxHeight <= heightTo)
                            .Where(x => x.MaxHeight >= weightFrom && x.MaxHeight <= weightTo)
                            .Where(x => x.MaxHeight >= ageFrom && x.MaxHeight <= ageTo);

            if (breed is not null)
            {
                dogs = dogs.Where(x => x.Breed.Name == breed);
            }

            var result = dogs.Select(x => _mapper.Map<Dog, DogViewModel>(x));

            return result.Count();
        }

        [HttpGet("{page}/{count}")]
        public IEnumerable<DogViewModel> GetByPage(int page = 1, int count = 5)
        {
            var dogsFiltered = _dogs.Skip((page - 1) * count).Take(count).ToList();
            var dogView = dogsFiltered.Select(x => _mapper.Map<Dog, DogViewModel>(x));

            return dogView;
        }
        [HttpGet("{id}")]
        public Dog GetDog(Guid id)
        {
            var result = _dogs.Where(x=> x.Id.CompareTo(id) == 0).FirstOrDefault();

            return result;
        }
    }
}
