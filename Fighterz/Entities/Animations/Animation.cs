using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighterz.Entities.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.XAudio2;

namespace Fighterz.Entities.Animations
{
    public class Animation
    {

        private List<Rectangle> _frames = new List<Rectangle>();

        private GameTime _frametime; //time since the last sprite update

        private float _frameRate;

        private int indexCurrentFrame=0;

        private float _timeLastFrame;

        private Vector2 _position;

        private bool _isLooped;

        public Animation(GameTime gameTime,float frameRate, bool isLooped)
        {
            _frametime = gameTime;
            _frameRate = frameRate;
            _isLooped = isLooped;
        }

        public void Update(GameTime gameTime, Vector2 pos)
        {
            if (gameTime.TotalGameTime.TotalSeconds - _frametime.TotalGameTime.TotalSeconds >= _frameRate)
            {
                if (indexCurrentFrame == _frames.Count)
                {
                    if (_isLooped)
                    {
                        indexCurrentFrame = -1;
                    }
                    else
                    {
                        EndAnimation();
                    }
                }
                indexCurrentFrame++;
                _frametime = gameTime;
            }

            _position = pos;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime,Texture2D texture)
        {
            spriteBatch.Draw(texture, _position, _frames[indexCurrentFrame], Color.CornflowerBlue);
        }
        public void AddFrame(Rectangle frame)
        {
            _frames.Add(frame);
        }

        public void EndAnimation()
        {

        }













        //public Animation(Texture2D texture,float duration, float frameRate,)
        //{
        //    Texture = texture;
        //    _duration = duration;
        //    _frameRate = frameRate;
        //}


    }
}
