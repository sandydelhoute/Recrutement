using AutoMapper;
using Recrutement.Dal.Entities;
using Recrutement.Dal.Models;

namespace Recrutement.Dal.Mappers
{
    public class MappingBllToDalProfile : Profile
    {
        public MappingBllToDalProfile()
        {
            CreateMap<Pokemon, PokemonEntity>();
        }
    }
}
