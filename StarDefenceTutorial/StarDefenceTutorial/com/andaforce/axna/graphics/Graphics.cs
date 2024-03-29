﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StarDefenceTutorial.com.andaforce.axna.graphics
{
    public abstract class Graphics
    {
        public bool IsVisible = true;
        public bool IsActive = true;

        public int X;
        public int Y;

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Render(SpriteBatch spriteBatch, Vector2 position)
        {

        }

        /// <summary>
        /// Устанавливает значение свойства IsRelative: определяет, как будут использованы координаты x,y для отрисовки графики
        /// true - прибавлены к значению переданных координат
        /// false - будут использованы как экранные
        /// </summary>
        /// <param name="relative"></param>
        public virtual void SetRelative(bool relative)
        {
            IsRelative = relative;
        }

        //
        protected virtual Vector2 GetDrawPosition(Vector2 basePosition)
        {
            Vector2 drawPosition = IsRelative
                           ? basePosition + new Vector2(X, Y)
                           : new Vector2(X, Y);

            return drawPosition;
        }


        protected bool IsRelative = true;
    }
}
