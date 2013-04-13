using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace StarDefenceTutorial.com.andaforce.game.entity.powerup
{
    public class PowerupColors
    {
        private static PowerupColors _instance;
        public Dictionary<PowerupType, Color> Colors = new Dictionary<PowerupType, Color>();

        private PowerupColors()
        {
            Colors.Add(PowerupType.AdditionalLives, Color.Red);
            Colors.Add(PowerupType.AdditionalScores, Color.Green);
            Colors.Add(PowerupType.IncreasedFirerate, Color.Violet);
            Colors.Add(PowerupType.IncreasedVelocity, Color.Blue);
            Colors.Add(PowerupType.IncreatedWeapon, Color.Orange);
        }

        public static PowerupColors GetInstance()
        {
            return _instance ?? (_instance = new PowerupColors());
        }
    }
}