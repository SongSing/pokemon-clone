using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_clone
{
    class Team
    {
        List<Pokemon> Pokemon = new List<Pokemon>();
        public Pokemon ActivePokemon => Pokemon[0];

        public Team()
        {

        }
    }
}
