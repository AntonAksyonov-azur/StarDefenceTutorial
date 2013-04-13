using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.game.config;
using StarDefenceTutorial.com.andaforce.game.service;

namespace StarDefenceTutorial.com.andaforce.game.entity.powerup.effects
{
    public class IncreateFireratePowerupEffect : AbstractPowerupEffect 
    {
        public IncreateFireratePowerupEffect()
        {
            EffectTime = Configuration.GetInstance().EffectTimeIncreaseFirerate;
        }

        public override void OnAddEffect()
        {
            var bulleService = AXNA.Game.Services.GetService(typeof (BulletService)) as BulletService;
            if (bulleService != null)
                bulleService.SetFirerate(Configuration.GetInstance().PlayerShipFirerate / 2.0f);
        }

        public override void OnRefreshEffect()
        {
            EffectTime = Configuration.GetInstance().EffectTimeIncreaseFirerate;
        }

        public override void OnRemoveEffect()
        {
            var bulleService = AXNA.Game.Services.GetService(typeof(BulletService)) as BulletService;
            if (bulleService != null)
                bulleService.SetFirerate(Configuration.GetInstance().PlayerShipFirerate);
        }
    }
}
