using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_clone
{
    class BattleState
    {
        public List<Team> Teams = new List<Team>(2);
        public int Turn;

        public BattleState()
        {
            Teams.Add(new Team());
            Teams.Add(new Team());
            Turn = 1;
        }
    }
}
