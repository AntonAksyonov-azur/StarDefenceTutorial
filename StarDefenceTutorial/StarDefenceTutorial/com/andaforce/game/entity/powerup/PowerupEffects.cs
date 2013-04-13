using System;
using StarDefenceTutorial.com.andaforce.game.entity.powerup.effects;

namespace StarDefenceTutorial.com.andaforce.game.entity.powerup
{
    public class PowerupEffects
    {
        public static AbstractPowerupEffect GetPowerupEffet(PowerupType type)
        {
            switch (type)
            {
                case PowerupType.AdditionalLives:
                    return new AddLivesPowerupEffect();
                case PowerupType.AdditionalScores:
                    return new AddScoresPowerupEffect();
                case PowerupType.IncreasedFirerate:
                    return new IncreateFireratePowerupEffect();
                case PowerupType.IncreasedVelocity:
                    return new IncreaseVelocityPowerupEffect();
                case PowerupType.IncreatedWeapon:
                    return new IncreaseWeaponPowerupEffect();
                default:
                    throw new Exception(String.Format("No effect for type {0}", type.ToString()));
            }
        }
    }
}