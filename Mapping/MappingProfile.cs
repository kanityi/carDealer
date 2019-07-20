using AutoMapper;
using carDealer.Controllers.Resources;
using carDealer.Models;

namespace carDealer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}