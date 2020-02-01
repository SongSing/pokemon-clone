using SFML;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;

namespace pokemon_clone
{
    class SpriteEntity : Entity
    {
        private Texture _texture;
        protected Sprite _sprite;
        public Vector2f Position
        {
            get => _sprite.Position;
            set => _sprite.Position = value;
        }

        public SpriteEntity(string texturePath)
        {
            _texture = Resources.Texture(texturePath);
            _sprite = new Sprite(_texture);
        }

        public virtual void Update(float delta) { }

        public virtual void Draw(RenderTarget target)
        {
            target.Draw(_sprite);
        }

        public virtual float DistanceTo(SpriteEntity other)
        {
            return (float)Math.Sqrt(Math.Pow(other.Position.X - Position.X, 2) + Math.Pow(other.Position.Y - Position.Y, 2));
        }
    }
}
