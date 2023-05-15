using AutoMapper;
using Recrutement.Dal.Interfaces;
using Recrutement.Dal.Models;
using System.Collections.Generic;
using System.Linq;

namespace Recrutement.Dal.Repositories
{
    public class PokemonRepository : IRepository<Pokemon>
    {
        private readonly IMapper mapper;
        private readonly PokemonContext context;
        public PokemonRepository()
        {
     
        }
        public PokemonRepository(IMapper mapper,PokemonContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }
        public Pokemon GetById(int id)
        {
            var pokemonEntity = context?.Pokemons?.FirstOrDefault(p => p.Id.Equals(id));
            return mapper?.Map<Pokemon>(pokemonEntity);
        }

        public Pokemon GetByName(string name)
        {
            var pokemonEntity = context?.Pokemons?.FirstOrDefault(p=>p.Name.Equals(name));
            return mapper?.Map<Pokemon>(pokemonEntity);  

        }

        public IEnumerable<Pokemon> GetAll()
        {
            var pokemonsEntity =  context?.Pokemons?.ToList();
            return mapper?.Map<IEnumerable<Pokemon>>(pokemonsEntity);
        }
      
    }
}
