using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Fighterz.Entities.Interfaces;
using System.Windows.Forms;

namespace Fighterz.Entities.Animations
{
    public class AnimationManager
    {

        private List<Animation> _animations = new List<Animation>();

        private bool _isAnimated = false;

        private int _indexOfAnimation;

        private GameTime _start;

        private Texture2D _texture;
        public Animation CurrentAnimation { get => _animations[_indexOfAnimation];}

        public AnimationManager(Texture2D texture, GameTime gameTime)
        {
            _texture = texture;
            _start = gameTime;
            _indexOfAnimation = 0;

        }

        public void Update(GameTime gameTime, Vector2 pos)
        {
            CurrentAnimation.Update(gameTime,pos);
        }


        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            CurrentAnimation.Draw(spriteBatch,gameTime,_texture); 
        }

        public void AddAnimation(GameTime gameTime,Rectangle frameSize, int numFrames, int gap, float frameRate, bool isLooped)
        {
            Animation toAdd = new Animation(gameTime,frameRate,isLooped);
            float x = 0;
            float y = 0;

            for (int i = 0; i < numFrames; i++)
            {
                toAdd.AddFrame(new Rectangle((int)x, (int)y, frameSize.Width, frameSize.Height));
                x += (frameSize.Width + gap);

            } 
            _animations.Add(toAdd);
        }


    }
}

