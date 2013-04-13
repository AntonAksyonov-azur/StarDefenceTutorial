using Microsoft.Xna.Framework;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.graphics;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.service;

namespace StarDefenceTutorial.com.andaforce.game.entity
{
    public class Enemy : StarDefenceTutorialEntity
    {
        private float _rotationAngle;

        public Enemy(float x, float y, int width, int height, Vector2 moveVector)
            : base(x, y, width, height)
        {
            this.MoveVector = moveVector;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            switch (CurrentState)
            {
                case EntityState.Move:
                    UpdateMove(gameTime);
                    UpdateCollision();

                    (Graphic as Image).SetRotationAngleByRadians(_rotationAngle += 0.01f);
                    break;
                case EntityState.Death:
                    UpdateDeath();
                    break;
            }
        }

        protected override void UpdateDeath()
        {
            Spritemap spritemap = Graphic as Spritemap;
            if (spritemap != null && spritemap.IsAnimationFinished())
            {
                ParentScreen.RemoveComponent(this);

                var enemyService = AXNA.Game.Services.GetService(typeof (EnemyService)) as EnemyService;
                enemyService.RemoveEnemy(this);
            }
        }

        protected override void UpdateMove(GameTime gameTime)
        {
            base.UpdateMove(gameTime);

            OutOfBorderCheck();
        }

        public void OutOfBorderCheck()
        {
            if (Position.X > Game.GraphicsDevice.Viewport.Width + Hitbox.Width) Position.X = 0.0f;
            if (Position.Y > Game.GraphicsDevice.Viewport.Height + Hitbox.Height) Position.Y = 0.0f;
            if (Position.X < -Hitbox.Width) Position.X = Game.GraphicsDevice.Viewport.Width + Hitbox.Width;
            if (Position.Y < -Hitbox.Height) Position.Y = Game.GraphicsDevice.Viewport.Height + Hitbox.Height;
        }
    }
}