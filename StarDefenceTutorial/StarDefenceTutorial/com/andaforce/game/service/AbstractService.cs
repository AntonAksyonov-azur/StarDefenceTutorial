using System;
using Microsoft.Xna.Framework;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;

namespace StarDefenceTutorial.com.andaforce.game.service
{
    public abstract class AbstractService : IUpdatableService
    {
        protected Screen ParentScreen;

        public virtual void UpdateService(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public virtual void SetParentScreen(Screen parentScreen)
        {
            ParentScreen = parentScreen;
        }
    }
}