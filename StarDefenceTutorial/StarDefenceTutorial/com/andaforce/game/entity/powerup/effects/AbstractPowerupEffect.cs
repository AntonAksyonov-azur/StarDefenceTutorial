using Microsoft.Xna.Framework;

namespace StarDefenceTutorial.com.andaforce.game.entity.powerup.effects
{
    public abstract class AbstractPowerupEffect
    {
        protected int EffectTime;

        public virtual void OnAddEffect()
        {
        }

        public virtual void OnRefreshEffect()
        {
        }

        public virtual void OnRemoveEffect()
        {
        }

        public virtual bool Update(GameTime gameTime)
        {
            EffectTime -= gameTime.ElapsedGameTime.Milliseconds;

            return EffectTime <= 0;
        }
    }
}