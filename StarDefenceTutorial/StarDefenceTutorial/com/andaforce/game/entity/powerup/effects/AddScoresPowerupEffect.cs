using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.game.service.gameplay;

namespace StarDefenceTutorial.com.andaforce.game.entity.powerup.effects
{
    public class AddScoresPowerupEffect : AbstractPowerupEffect
    {
        public override void OnAddEffect()
        {
            var gameplayService = AXNA.Game.Services.GetService(typeof(GameplayService)) as GameplayService;
            if (gameplayService != null) gameplayService.ChangeScore(50);
        }
    }
}
