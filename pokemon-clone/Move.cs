using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_clone
{
    abstract class Move
    {
        public int Power;
        public float Accuracy;

        protected Move(int power, int accuracy)
        {
            Power = power;
            Accuracy = accuracy;
        }

        public abstract void Invoke(int side, Pokemon owner, BattleState state);
    }
}
