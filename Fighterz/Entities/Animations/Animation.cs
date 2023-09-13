using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighterz.Entities.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Fighterz.Entities.Animations
{
    public class Animation : ISprite, IEntity
    {
        private float _duration;

        private List<Rectangle> _frames = new List<Rectangle>();

        private GameTime _frametime; //time since the last sprite update

        private GameTime _frameRate;

        public GameTime FrameTime { get => _frametime; set => _frametime = value; }
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle SourceRect { get; set; }
        public float Rotation { get; set; }
        public Vector2 Origin { get; set; }
        public Vector2 Scale { get; set; }
        public float LayerDepth { get; set; }
        public SpriteEffects SpriteEffects { get; set; }


        public Animation(Texture2D texture, float duration,Vector2 pos,Rectangle sourceRect, GameTime gameTime)
        {
            Texture = texture;
            _duration = duration;
            Position = pos;
            SourceRect = sourceRect;
            FrameTime = gameTime;

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(Texture, Position, SourceRect, Color.White, Rotation,Origin, Scale, SpriteEffects, LayerDepth);
        }







#







        //public Animation(Texture2D texture,float duration, float frameRate,)
        //{
        //    Texture = texture;
        //    _duration = duration;
        //    _frameRate = frameRate;
        //}


    }
}
