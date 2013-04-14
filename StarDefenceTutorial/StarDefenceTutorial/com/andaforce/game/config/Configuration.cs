using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StarDefenceTutorial.com.andaforce.game.config
{
    public class Configuration
    {
        public ScreenConfiguration ScreenConfiguration;
        public PlayerShipConfiguration PlayerShipConfiguration;
        public BulletConfiguration BulletConfiguration;
        public PowerupConfiguration PowerupConfiguration;
        public EnemyConfiguration EnemyConfiguration;
        public GameplayConfiguration GameplayConfiguration;

        //
        private static Configuration _instance;

        public static void UnloadConfiguration()
        {
            try
            {
                _instance = CreateDefault();

                XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
                TextWriter writer = new StreamWriter("config.xml");
                serializer.Serialize(writer, _instance);
            }
            catch (IOException e)
            {
                MessageBox.Show("Error in unloading configuration file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LoadConfiguration()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof (Configuration));
                TextReader reader = new StreamReader("config.xml");
                _instance = (Configuration) serializer.Deserialize(reader);
            }
            catch (IOException e)
            {
                _instance = CreateDefault();

                MessageBox.Show("Error in loading configuration file! Using default configuration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Configuration Get()
        {
            return _instance;
        }

        private static Configuration CreateDefault()
        {
            _instance = new Configuration();
            _instance.ScreenConfiguration = new ScreenConfiguration();
            _instance.PlayerShipConfiguration = new PlayerShipConfiguration();
            _instance.BulletConfiguration = new BulletConfiguration();
            _instance.PowerupConfiguration = new PowerupConfiguration();
            _instance.EnemyConfiguration = new EnemyConfiguration();
            _instance.GameplayConfiguration = new GameplayConfiguration();

            return _instance;
        }
    }
}