using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.graphics;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using StarDefenceTutorial.com.andaforce.game.config;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.entity.powerup;

namespace StarDefenceTutorial.com.andaforce.game.service
{
    public class PowerupService : AbstractSpawnService
    {
        private readonly int _powerupsAppearsInterval;
        private readonly List<Powerup> _powerups = new List<Powerup>();
        public Texture2D PowerupTexture;
        private int _powerupElapsedTime;

        public PowerupService(Screen parentScreen, Texture2D powerupTexture) : base(parentScreen)
        {
            PowerupTexture = powerupTexture;
            _powerupsAppearsInterval = Configuration.Get().PowerupConfiguration.PowerupAppearsInterval;
        }

        public override void CreateEntity()
        {
            var type = (PowerupType) AXNA.Rnd.Next(0, 5);
  
            var powerup = new Powerup(type,
                                      Configuration.Get().ScreenConfiguration.ScreenWidth,
                                      AXNA.Rnd.Next(0, Configuration.Get().ScreenConfiguration.ScreenHeight), 
                                      32, 32);
            var idle = new Spritemap(PowerupTexture, 32, 32);
            idle.AddAnimation(EntityState.Idle, new Point(0, 0), 23, 16.0f, true);
            idle.SetOverlayColor(PowerupColors.GetInstance().Colors[type]);

            powerup.SetUpGraphics(idle, idle, idle);

            _powerups.Add(powerup);
            ParentScreen.AddComponent(powerup);
        }

        public override void UpdateService(GameTime gameTime)
        {
            if (_powerupElapsedTime > _powerupsAppearsInterval)
            {
                CreateEntity();
                _powerupElapsedTime = 0;
            }
            else
            {
                _powerupElapsedTime += gameTime.ElapsedGameTime.Milliseconds;
            }
        }

        public void MovePowerups(float scrollSpeed)
        {
            foreach (Powerup e in _powerups)
            {
                e.Position.X += scrollSpeed;
            }
        }

        public void RemovePowerup(Powerup powerup)
        {
            _powerups.Remove(powerup);
        }
    }
}