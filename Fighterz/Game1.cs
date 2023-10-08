using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Fighterz.Managers;
using Fighterz.Entities;
using Fighterz.Entities.Fighters;
using System.Runtime.CompilerServices;

namespace Fighterz
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private EntityManager _entityManager;
        private Texture2D _testFighter1;
        private bool isFirstUpdate = true;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _entityManager = new EntityManager();


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _testFighter1 = Content.Load<Texture2D>(@"Assets/TestFighter1");
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (isFirstUpdate)
            {
                _entityManager.AddEntity(new TestFighter(gameTime,1, new Vector2(200,200),_testFighter1));
                isFirstUpdate = false;
            }





            _entityManager.Update(gameTime);






            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _entityManager.Draw(_spriteBatch, gameTime);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}