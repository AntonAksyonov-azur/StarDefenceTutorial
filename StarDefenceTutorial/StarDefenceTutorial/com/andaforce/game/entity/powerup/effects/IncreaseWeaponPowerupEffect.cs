using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.game.config;
using StarDefenceTutorial.com.andaforce.game.service;

namespace StarDefenceTutorial.com.andaforce.game.entity.powerup.effects
{
    public class IncreaseWeaponPowerupEffect : AbstractPowerupEffect
    {
        public IncreaseWeaponPowerupEffect()
        {
            EffectTime = Configuration.GetInstance().EffectTimeIncreaseWeapon;
        }

        public override void OnAddEffect()
        {
            var bulletService = AXNA.Game.Services.GetService(typeof (BulletService)) as BulletService;
            if (bulletService != null)
                bulletService.SetTripleMode(true);
        }

        public override void OnRefreshEffect()
        {
            EffectTime = Configuration.GetInstance().EffectTimeIncreaseWeapon;
        }

        public override void OnRemoveEffect()
        {
            var bulletService = AXNA.Game.Services.GetService(typeof(BulletService)) as BulletService;
            if (bulletService != null)
                bulletService.SetTripleMode(false);
        }
    }
}
