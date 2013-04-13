using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.entity;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.service.gameplay;

namespace StarDefenceTutorial.com.andaforce.game.entity.powerup
{
    public class Powerup : StarDefenceTutorialEntity 
    {
        public PowerupType PowerupType { get; private set; }

        public Powerup(PowerupType powerupType, float x, float y, int width, int height) : base(x, y, width, height)
        {
            PowerupType = powerupType;
        }

        protected override void UpdateCollision()
        {
            foreach (AXNAGameComponent t in ParentScreen.GameComponents)
            {
                if (!(t is PlayerShip)) continue;

                var p = (t as PlayerShip);

                if (p.CollideWith(this) && p.GetCurrentState() != EntityState.Death)
                {
                    p.AppyPowerup();
                }
            }
        }
    }
}
