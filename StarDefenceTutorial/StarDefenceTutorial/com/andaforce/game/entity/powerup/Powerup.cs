using Microsoft.Xna.Framework;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.entity;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.entity.powerup.effects;
using StarDefenceTutorial.com.andaforce.game.service;

namespace StarDefenceTutorial.com.andaforce.game.entity.powerup
{
    public class Powerup : StarDefenceTutorialEntity
    {
        public PowerupType PowerupType { get; private set; }
        public AbstractPowerupEffect Effect { get; private set; } 

        public Powerup(PowerupType powerupType, float x, float y, int width, int height) : base(x, y, width, height)
        {
            PowerupType = powerupType;
            Effect = PowerupEffects.GetPowerupEffet(powerupType);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            UpdateCollision();
            UpdateMove(gameTime);
        }

        protected override void UpdateMove(GameTime gameTime)
        {
            if (Position.X < Hitbox.Width)
            {
                ParentScreen.RemoveComponent(this);
            }
        }

        protected override void UpdateCollision()
        {
            foreach (AXNAGameComponent t in ParentScreen.GameComponents)
            {
                if (!(t is PlayerShip)) continue;

                var p = (t as PlayerShip);

                if (p.CollideWith(this) && p.GetCurrentState() != EntityState.Death)
                {
                    var powerupService = AXNA.Game.Services.GetService(typeof (PowerupService)) as PowerupService;
                    if (powerupService != null) powerupService.RemovePowerup(this);

                    ParentScreen.RemoveComponent(this);
                    p.AddPowerup(this);
                }
            }
        }
    }
}