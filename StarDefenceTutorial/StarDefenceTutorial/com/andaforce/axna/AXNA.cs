using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace StarDefenceTutorial.com.andaforce.axna
{
    // Класс хранит ссылки на все общие объекты, необходимые для работы основных компонентов XNA
    // Все ссылки должны быть инициализированы до непосредственного использования остальных классов
// ReSharper disable InconsistentNaming
    internal static class AXNA
// ReSharper restore InconsistentNaming
    {
        internal static Game Game;
        internal static ContentManager Content;
        internal static GraphicsDevice GraphicsDevice;
        internal static SpriteBatch SpriteBatch;

        internal static Random Rnd = new Random();

        internal static float GetTimeIntervalValue(GameTime gameTime)
        {
            return (float)gameTime.ElapsedGameTime.Milliseconds / 1000;
        }

        //internal static bool DebugMode = true;
        internal static bool DebugMode = false;
    }
}
