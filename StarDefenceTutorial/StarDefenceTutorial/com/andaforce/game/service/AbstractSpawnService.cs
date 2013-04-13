using StarDefenceTutorial.com.andaforce.axna.screen.manager;

namespace StarDefenceTutorial.com.andaforce.game.service
{
    public class AbstractSpawnService : AbstractService
    {
        protected Screen ParentScreen;

        protected AbstractSpawnService(Screen parentScreen)
        {
            ParentScreen = parentScreen;
        }

        public virtual void SetParentScreen(Screen parentScreen)
        {
            ParentScreen = parentScreen;
        }

        public virtual void CreateEntity()
        {
        }
    }
}