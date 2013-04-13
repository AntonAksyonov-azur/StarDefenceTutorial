using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.entity;
using StarDefenceTutorial.com.andaforce.axna.graphics;
using StarDefenceTutorial.com.andaforce.game.constants;

namespace StarDefenceTutorial.com.andaforce.game.entity
{
    public class StarDefenceTutorialEntity : BaseGameComponent
    {
        protected String CurrentState = EntityState.None;
        public bool LeftOrientation = false;
        protected Vector2 MoveVector = Vector2.Zero;
        protected Dictionary<String, Graphics> States = new Dictionary<String, Graphics>();

        public StarDefenceTutorialEntity(float x, float y, int width, int height)
            : base(null, x, y, width, height)
        {
        }

        public void SetUpGraphics(Graphics idle, Graphics move, Graphics death, String initialState = EntityState.Idle)
        {
            States.Add(EntityState.Idle, idle);
            States.Add(EntityState.Move, move);
            States.Add(EntityState.Death, death);

            SwitchState(initialState, false);
        }

        public String GetCurrentState()
        {
            return CurrentState;
        }

        public Vector2 GetMoveVector()
        {
            return MoveVector;
        }

        public virtual void SwitchState(String state, bool reflected)
        {
            if (state != CurrentState)
            {
                Graphic = States[state];
                CurrentState = state;
                LeftOrientation = reflected;
            }

            // Графические эффекты
            if (Graphic is Image)
            {
                (Graphic as Image).SpriteEffect = reflected ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
            }

            if (Graphic is Spritemap)
            {
                (Graphic as Spritemap).PlayAnimation(state);
            }
        }

        protected virtual void UpdateMove(GameTime gameTime)
        {
            Position.X += AXNA.GetTimeIntervalValue(gameTime) * MoveVector.X;
            Position.Y += AXNA.GetTimeIntervalValue(gameTime) * MoveVector.Y;
        }

        protected virtual void UpdateCollision()
        {
        }

        protected virtual void UpdateDeath()
        {
            // Дожидаемся конца анимации и удаляем объект
            var spritemap = Graphic as Spritemap;
            if (spritemap != null && spritemap.IsAnimationFinished())
            {
                ParentScreen.RemoveComponent(this);
            }
                // Если это не анимация, удаляем объект немедленно
            else if (spritemap == null)
            {
                ParentScreen.RemoveComponent(this);
            }
        }
    }
}