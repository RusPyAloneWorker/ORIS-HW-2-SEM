using AutoMapper;
using Dogs.Api.Models;


namespace Dogs.Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Dog, DogViewModel>();
            this.CreateMap<DogViewModel, Dog>();
        }
    }
}
