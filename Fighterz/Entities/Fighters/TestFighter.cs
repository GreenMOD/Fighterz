using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighterz.Entities.Animations;
using Fighterz.Entities.Fighters;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fighterz.Entities.Fighters
{
    internal class TestFighter : Fighter
    {
        private int _player; //The player controling them

        private string _name = "Test"; //Name of Character 

        private bool _isStunned = false;

        private bool _hasInput = false;

        private Vector2 _pos;

        public override int Player { get { return _player; } }

        public override string Name { get { return _name; } }

        public override bool IsStunned { get { return _isStunned; } set { _isStunned = value; } }

        public override bool HasInput { get { return _hasInput; } set { _hasInput = value; } }

        public override Vector2 Position { get { return _pos; } set { _pos = value; } }

        private AnimationManager _animationManager;

        //Input handler
        public TestFighter(GameTime gameTime, int player, Vector2 pos,Texture2D texture2D)
        {
            _animationManager = new AnimationManager(texture2D, gameTime);
            _player = player;
            Position = pos;
            _animationManager.AddAnimation(gameTime,new Rectangle(0, 0, 8, 8), 6, 2,5,true);
        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            _animationManager.Draw(spriteBatch, gameTime);
        }

        public override void HeavyAttack()
        {

        }

        public override void LightAttack()
        {

        }

        public override void MediumAttack()
        {

        }

        public override void Movement()
        {

        }

        public override void SpecialAttack()
        {

        }

        public override void UltimateAttack()
        {

        }

        public override void Update(GameTime gameTime)
        {
            _animationManager.Update(gameTime,Position);
        }
       
    }
}
