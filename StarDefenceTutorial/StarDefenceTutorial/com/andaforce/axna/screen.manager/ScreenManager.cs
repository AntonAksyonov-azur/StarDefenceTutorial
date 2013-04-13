using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace StarDefenceTutorial.com.andaforce.axna.screen.manager
{
    internal static class ScreenManager
    {
        private static readonly List<Screen> Screens = new List<Screen>();
        private static Screen _nextScreen;
        private static Screen _prevScreen;

        private static Screen _activeScreen;

        internal static Screen GetActiveScreen()
        {
            return _activeScreen;
        }

        internal static void AddScreen(Screen screen)
        {
            if (Screens.Any(scr => scr.Name == screen.Name))
            {
                throw new Exception("Screen with this name already registered!");
            }

            Screens.Add(screen);
        }

        internal static int GetScreensCount()
        {
            return Screens.Count;
        }

        internal static Screen GetScreenByIndex(int index)
        {
            return Screens[index];
        }

        internal static Screen GetScreenByName(string name)
        {
            foreach (Screen scr in Screens)
            {
                if (scr.Name == name)
                {
                    return scr;
                }

            }
            throw new Exception(String.Format("Screen with name {0} is not found", name));
        }

        internal static void ActivateScreen(Screen screen)
        {
            _nextScreen = screen;
        }

        internal static void ActivateScreenByIndex(int index)
        {
            ActivateScreen(GetScreenByIndex(index));
        }

        internal static void ActivateScreenByName(string name)
        {
            ActivateScreen(GetScreenByName(name));
        }

        internal static void ActivatePreviousScreen()
        {
            if (_prevScreen != null)
            {
                ActivateScreenByName(_prevScreen.Name);
            }
        }

        //
        internal static void Update(GameTime gameTime)
        {
            if (_nextScreen != null)
            {
                if (_activeScreen != null)
                {
                    _activeScreen.OnRemove();
                }
                _prevScreen = _activeScreen;

                _activeScreen = _nextScreen;
                _activeScreen.Initialize();

                _nextScreen = null;
            }

            //
            if (_activeScreen != null)
            {
                _activeScreen.OnUpdate(gameTime);
            }
        }

        internal static void Draw(GameTime gameTime)
        {
            if (_activeScreen != null)
            {
                _activeScreen.OnDraw(gameTime);
            }
        }

    }
}
