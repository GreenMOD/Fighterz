using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighterz.Entities.Animations;
using Fighterz.Entities.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fighterz.Entities
{
    public class Fighter : IEntity
    {
        #region Declarations and Properties
        private string _player; //The player controling them

        private string _name; //Name of Character 

        //private List<Move> _moveset = new List<Move>();

        private bool _isStunned = false;

        private bool _hasInput = false;

        private Vector2 _pos;

        private AnimationManager _animationManager;

        public string Player { get { return _player; } }

        public string Name { get { return _name;} }

        public bool IsStunned { get { return _isStunned; } set { _isStunned = value; } }

        public bool HasInput { get { return _hasInput; } set { _hasInput = value; } }

        public Vector2 Position { get { return _pos; } set { _pos = value; } }

        EventHandler _onInput; //Used to complete the specifc input once the input manager has determined the input

        #endregion

        #region Methods



        public Fighter()
        {

        }
       
        public void Update(GameTime gameTime)
        {
            ///If stunned dont do anything.
            ///Else Check for inputs.
            ///If any inputs are detected act upon them



            if (!IsStunned)
            {
                ///if(no inputs)
                ///play idle animation
                ///else complete input

            }
            //_animationManager.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {

        }


        #endregion

        public void Attack()
        {
            
        }

    }
}
