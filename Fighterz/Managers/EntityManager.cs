using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Fighterz.Entities.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Fighterz.Managers
{
    public class EntityManager
    {

       private List<IEntity> _entities = new List<IEntity>();

       private List<IEntity> _toAdd = new List<IEntity>();

       private List<IEntity> _toRemove = new List<IEntity>();


        public void Update(GameTime gameTime)
        {

            foreach (IEntity E in _entities)
            {
                E.Update(gameTime);
            }
            foreach (IEntity E in _toAdd)
            {

                _entities.Add(E);


            }
            foreach (IEntity E in _toRemove)
            {
                _entities.Remove(E);
            }
            _toAdd.Clear();
            _toRemove.Clear();
        }



        public void AddEntity(IEntity entity)
        {
            _toAdd.Add(entity);
        }

        public void RemoveEntity(IEntity entity)
        {
            _toRemove.Add(entity);
        }
        /// <summary>
        /// Returns a list of entites of selected E
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <returns></returns>
        public List<E> GetEntities<E>() where E : IEntity
        {
            return _entities.OfType<E>().ToList();
        }

        public void Clear()
        {
            foreach (IEntity e in _entities)
            {
                _toRemove.Add(e);
            }
        }
        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (IEntity E in _entities)
            {
                E.Draw(spriteBatch, gameTime);
            }
        }
    }
}
