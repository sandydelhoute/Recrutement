using Recrutement.Dal.Interfaces;
using Recrutement.Dal.Models;
using Recrutement.Dal.Repositories;
using Recrutement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recrutement.Services.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly IRepository<Pokemon> pokemonRepository;

        public PokemonService(IRepository<Pokemon> pokemonRepository)
        {
            this.pokemonRepository = pokemonRepository;
        }
        public IEnumerable<Pokemon> GetAll()
        {
            return this.pokemonRepository.GetAll();
        }

        public Pokemon GetById(int id)
        {
            return this.pokemonRepository.GetById(id);
        }

        public Pokemon GetByName(string name)
        {
            return this.pokemonRepository.GetByName(name);
        }
    }
}
