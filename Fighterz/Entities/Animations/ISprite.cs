using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighterz.Entities.Animations
{
    public interface ISprite
    {
        public Texture2D Texture { get; set; }

        public Vector2 Position { get;  set;  }

        public Rectangle SourceRect { get; set; }

        public float Rotation { get; set; }
        public Vector2 Origin { get; set; }
        public Vector2 Scale { get; set; }
        public float LayerDepth { get; set; }
        public SpriteEffects SpriteEffects { get; set; }
    }
}
