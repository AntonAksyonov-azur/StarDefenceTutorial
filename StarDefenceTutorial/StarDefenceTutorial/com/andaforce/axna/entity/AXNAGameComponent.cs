using Microsoft.Xna.Framework;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;

namespace StarDefenceTutorial.com.andaforce.axna.entity
{
// ReSharper disable InconsistentNaming
    public abstract class AXNAGameComponent : DrawableGameComponent
// ReSharper restore InconsistentNaming
    {
        public Screen ParentScreen;

        protected AXNAGameComponent()
            : base(AXNA.Game)
        {
        }
    }
}