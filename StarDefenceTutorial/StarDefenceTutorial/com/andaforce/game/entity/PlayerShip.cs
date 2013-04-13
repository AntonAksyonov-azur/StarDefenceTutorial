using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.entity;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.service;
using StarDefenceTutorial.com.andaforce.game.service.gameplay;

namespace StarDefenceTutorial.com.andaforce.game.entity
{
    public class PlayerShip : StarDefenceTutorialEntity
    {
        public float HorizontalAcceleration;
        public float MaxHorizontalSpeed;

        public float Velocity;

        public PlayerShip(float x, float y, int width, int height)
            : base(x, y, width, height)
        {
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            switch (CurrentState)
            {
                case EntityState.Idle:
                case EntityState.Move:
                    SwitchState(EntityState.Idle, LeftOrientation);

                    UpdateHorizontalMoveKeys(gameTime);
                    UpdateVerticalMoveKeys(gameTime);
                    UpdateShootKeys(gameTime);

                    UpdateMove(gameTime);
                    UpdateCollision();
                    break;
                case EntityState.Death:
                    UpdateDeath();
                    break;
                case EntityState.None:
                    break;
            }
        }

        protected override void UpdateCollision()
        {
            foreach (AXNAGameComponent t in ParentScreen.GameComponents)
            {
                if (!(t is Enemy)) continue;

                var e = (t as Enemy);

                if (e.CollideWith(this) && e.GetCurrentState() != EntityState.Death)
                {
                    SwitchState(EntityState.Death, LeftOrientation);

                    var gameplayService =
                        AXNA.Game.Services.GetService(typeof (GameplayService)) as GameplayService;
                    if (gameplayService != null)
                    {
                        gameplayService.ChangePlayerLives(-1);
                        gameplayService.ReduceScoreForDeath();
                    }

                }
            }
        }

        protected override void UpdateMove(GameTime gameTime)
        {
            // Пустая реализация
        }

        private void UpdateHorizontalMoveKeys(GameTime gameTime)
        {
            if (InputManager.IsKeyDown(Keys.Left))
            {
                SwitchState(EntityState.Move, true);

                //moveVector.X += moveVector.X > Math.Abs(MaxHorizontalSpeed) ? 0 : HorizontalAcceleration;
                if (Position.X > 0)
                {
                    Position.X -= Velocity*AXNA.GetTimeIntervalValue(gameTime);
                }
            }

            if (InputManager.IsKeyDown(Keys.Right))
            {
                SwitchState(EntityState.Move, false);

                // moveVector.X -= moveVector.X < -MaxHorizontalSpeed ? 0 : HorizontalAcceleration;
                if (Position.X < AXNA.GraphicsDevice.Viewport.Width - Hitbox.Width)
                {
                    Position.X += Velocity*AXNA.GetTimeIntervalValue(gameTime);
                }
            }
        }

        private void UpdateVerticalMoveKeys(GameTime gameTime)
        {
            if (InputManager.IsKeyDown(Keys.Up))
            {
                SwitchState(EntityState.Move, LeftOrientation);

                if (Position.Y > 0)
                {
                    Position.Y -= Velocity*AXNA.GetTimeIntervalValue(gameTime);
                }
            }

            if (InputManager.IsKeyDown(Keys.Down))
            {
                SwitchState(EntityState.Move, LeftOrientation);

                if (Position.Y < AXNA.GraphicsDevice.Viewport.Height - Hitbox.Height)
                {
                    Position.Y += Velocity*AXNA.GetTimeIntervalValue(gameTime);
                }
            }
        }

        private void UpdateShootKeys(GameTime gameTime)
        {
            if (InputManager.IsKeyDown(Keys.Space))
            {
                var bulletService = AXNA.Game.Services.GetService(typeof (BulletService)) as BulletService;
                if (bulletService != null) bulletService.TryShoot(this);
            }
        }
    }
}