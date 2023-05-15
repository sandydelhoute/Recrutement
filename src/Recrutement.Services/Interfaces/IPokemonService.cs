using Recrutement.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recrutement.Services.Interfaces
{
    public interface IPokemonService
    {
        IEnumerable<Pokemon> GetAll(); 

        Pokemon GetById(int id);    

        Pokemon GetByName(string name);
    }
}
