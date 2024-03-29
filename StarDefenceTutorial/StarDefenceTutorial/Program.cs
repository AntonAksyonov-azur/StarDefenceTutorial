using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using StarDefenceTutorial.com.andaforce.game.config;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.screens;

namespace StarDefenceTutorial
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ScreenManager.AddScreen(new MenuScreen());
            ScreenManager.AddScreen(new GameScreen());
            ScreenManager.AddScreen(new RecordsScreen());
            ScreenManager.ActivateScreenByName(ScreenNames.Game);

            //Configuration.UnloadConfiguration();
            Configuration.LoadConfiguration();

            var game = new AXNAGame(Configuration.Get().ScreenConfiguration.ScreenWidth, Configuration.Get().ScreenConfiguration.ScreenHeight);
            game.Run();

        }
    }
#endif
}

