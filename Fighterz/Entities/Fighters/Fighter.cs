using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighterz.Entities;
using Fighterz.Entities.Animations;
using Fighterz.Entities.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fighterz.Entities.Fighters
{
    public abstract class Fighter: IEntity
    {
        #region Declarations and Properties
        private int _player; //The player controling them

        private string _name; //Name of Character 

        private bool _isStunned = false;

        private bool _hasInput = false;

        private Vector2 _pos;

        public abstract int Player { get; }

        public abstract string Name { get; }
        public abstract bool IsStunned { get; set; }

        public abstract bool HasInput { get; set; }

        public abstract Vector2 Position { get; set; }

        //Input handler

        #endregion

        #region Methods


        public abstract void Update(GameTime gameTime);

        public abstract void Draw(SpriteBatch spriteBatch, GameTime gameTime);

        public abstract void Movement();

        public abstract void LightAttack();

        public abstract void MediumAttack();

        public abstract void HeavyAttack();

        public abstract void SpecialAttack();

        public abstract void UltimateAttack();


        #endregion

    }
}
