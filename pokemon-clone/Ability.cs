using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_clone
{
    abstract class Ability
    {
        public static List<Ability> GlobalList;

        protected Ability()
        {

        }

        public abstract void Invoke(int side, Pokemon owner, BattleState state);
    }
}
