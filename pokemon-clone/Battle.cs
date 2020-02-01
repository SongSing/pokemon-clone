using SFML;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;

namespace pokemon_clone
{
    class Battle : Entity
    {
        public BattleState State;

        public Battle()
        {
            State = new BattleState();
        }

        public void Update(float delta)
        {
        }

        public void Draw(RenderTarget target)
        {
        }
    }
}
