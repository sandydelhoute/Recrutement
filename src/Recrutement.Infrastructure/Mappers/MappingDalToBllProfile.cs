using AutoMapper;
using Recrutement.Dal.Entities;
using Recrutement.Dal.Models;

namespace Recrutement.Dal.Mappers
{
    public class MappingDalToBllProfile: Profile
    {
        public MappingDalToBllProfile()
        {
            CreateMap<PokemonEntity, Pokemon>();
        }
    }
}
