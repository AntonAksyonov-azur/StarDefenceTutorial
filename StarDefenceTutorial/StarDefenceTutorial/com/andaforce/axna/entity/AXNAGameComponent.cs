using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;

namespace StarDefenceTutorial.com.andaforce.axna.entity
{
    public abstract class AXNAGameComponent : DrawableGameComponent
    {
        public Screen ParentScreen;

        public AXNAGameComponent()
            : base(AXNA.Game)
        {
            
        }

    }
}
