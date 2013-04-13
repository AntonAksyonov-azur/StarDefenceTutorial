using System;
using Microsoft.Xna.Framework;

namespace StarDefenceTutorial.com.andaforce.game.service
{
    public abstract class AbstractService : IUpdatableService
    {
        public virtual void UpdateService(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}