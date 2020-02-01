using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;

namespace pokemon_clone
{
    class Pokemon : SpriteEntity
    {
        public static List<Pokemon> GlobalList;
          
        private List<Move> _moves = new List<Move>(4);
        private List<int> _stats = new List<int>(8);

        public int Hp
        {
            get => _stats[0];
            set => _stats[0] = value;
        }
        public int Atk
        {
            get => _stats[1];
            set => _stats[1] = value;
        }
        public int Def
        {
            get => _stats[2];
            set => _stats[2] = value;
        }
        public int SpAtk
        {
            get => _stats[3];
            set => _stats[3] = value;
        }
        public int SpDef
        {
            get => _stats[4];
            set => _stats[4] = value;
        }
        public int Speed
        {
            get => _stats[5];
            set => _stats[5] = value;
        }
        public int Acc
        {
            get => _stats[6];
            set => _stats[6] = value;
        }
        public int Eva
        {
            get => _stats[7];
            set => _stats[7] = value;
        }
        public bool IsAlive => Hp > 0;

        public Pokemon(string spritePath) : base(spritePath)
        {

        }

        public override void Update(float delta)
        {
            base.Update(delta);
        }

        public override void Draw(RenderTarget target)
        {
            base.Draw(target);
        }
    }
}
