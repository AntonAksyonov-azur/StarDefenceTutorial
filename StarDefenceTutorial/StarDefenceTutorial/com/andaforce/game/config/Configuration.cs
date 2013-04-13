namespace StarDefenceTutorial.com.andaforce.game.config
{
    public class Configuration
    {
        // Screen sizes
        public int ScreenWidth = 720;
        public int ScreenHeight = 480;

        // PlayerShip
        public int PlayerShipVelocity = 100;

        // BulletService
        public float Firerate = 0.3f;
        public int BulletVelocity = 300;

        // Powerups time values
        public int EffectTimeIncreaseVelocity = 10000;
        public int EffectTimeIncreaseFirerate = 10000;
        public int EffectTimeIncreaseWeapon = 10000;

        //
        private static Configuration _instance;

        public static Configuration GetInstance()
        {
            return _instance ?? (_instance = new Configuration());
        }
    }
}