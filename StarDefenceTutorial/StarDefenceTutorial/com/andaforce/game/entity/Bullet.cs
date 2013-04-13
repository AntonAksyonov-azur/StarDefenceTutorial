using Microsoft.Xna.Framework;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.service.gameplay;

namespace StarDefenceTutorial.com.andaforce.game.entity
{
    public class Bullet : StarDefenceTutorialEntity
    {
        public Bullet(float x, float y, int width, int height, int speed)
            : base(x, y, width, height)
        {
            MoveVector = new Vector2(speed, 0);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            UpdateMove(gameTime);
            UpdateCollision();
        }

        protected override void UpdateMove(GameTime gameTime)
        {
            base.UpdateMove(gameTime);

            // Удаляем пулю при выходе за границы экрана
            if (!GetEntityRectangle().Intersects(AXNA.GraphicsDevice.Viewport.Bounds))
            {
                ParentScreen.RemoveComponent(this);
            }
        }

        protected override void UpdateCollision()
        {
            for (int i = 0; i < ParentScreen.GameComponents.Count; i++)
            {
                if (ParentScreen.GameComponents[i] is Enemy)
                {
                    var e = (ParentScreen.GameComponents[i] as Enemy);

                    if (e.CollideWith(this) && e.GetCurrentState() != EntityState.Death)
                    {
                        e.SwitchState(EntityState.Death, LeftOrientation);
                        ParentScreen.RemoveComponent(this);

                        var gameplayService =
                            AXNA.Game.Services.GetService(typeof (GameplayService)) as GameplayService;
                        if (gameplayService != null)
                        {
                            gameplayService.AddHit();
                            gameplayService.AddScoreForHit();
                        }
                    }
                }
            }
        }
    }
}