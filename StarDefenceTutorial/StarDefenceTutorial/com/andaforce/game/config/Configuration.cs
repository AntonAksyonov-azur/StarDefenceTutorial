namespace StarDefenceTutorial.com.andaforce.game.config
{
    public class Configuration
    {
        public int ScreenWidth = 1280;
        public int ScreenHeight = 720;

        private static Configuration _instance;

        public static Configuration GetInstance()
        {
            return _instance ?? (_instance = new Configuration());
        }
    }
}