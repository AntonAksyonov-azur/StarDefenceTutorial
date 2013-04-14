using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.game.config;
using StarDefenceTutorial.com.andaforce.game.service;

namespace StarDefenceTutorial.com.andaforce.game.entity.powerup.effects
{
    public class IncreaseVelocityPowerupEffect : AbstractPowerupEffect
    {
        public IncreaseVelocityPowerupEffect()
        {
            EffectTime = Configuration.Get().PowerupConfiguration.EffectTimeIncreaseVelocity;
        }

        public override void OnAddEffect()
        {
            var playerShipservice = AXNA.Game.Services.GetService(typeof (PlayerShipService)) as PlayerShipService;
            if (playerShipservice != null)
                playerShipservice.SetPlayerShipVelocity(Configuration.Get().PlayerShipConfiguration.PlayerShipVelocity * 2);
        }

        public override void OnRemoveEffect()
        {
            var playerShipservice = AXNA.Game.Services.GetService(typeof (PlayerShipService)) as PlayerShipService;
            if (playerShipservice != null)
                playerShipservice.SetPlayerShipVelocity(Configuration.Get().PlayerShipConfiguration.PlayerShipVelocity);
        }

        public override void OnRefreshEffect()
        {
            EffectTime = Configuration.Get().PowerupConfiguration.EffectTimeIncreaseVelocity;
        }
    }
}