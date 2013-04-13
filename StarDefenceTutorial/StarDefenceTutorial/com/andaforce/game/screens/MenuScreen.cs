using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.entity;
using StarDefenceTutorial.com.andaforce.axna.graphics;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using StarDefenceTutorial.com.andaforce.axna.ui;
using StarDefenceTutorial.com.andaforce.axna.entity.background;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.entity;

namespace StarDefenceTutorial.com.andaforce.game.screens
{
    public class MenuScreen : Screen
    {
        private ClickableLabel _labelPlay;
        private ClickableLabel _labelExit;



        internal MenuScreen()
            : base(ScreenNames.Menu)
        {
        }

        internal override bool Initialize()
        {
            /*
            Texture2D texture = Commons.Content.Load<Texture2D>("Textures/explosion");
            spritemap = new Spritemap(texture, 64, 64);
            spritemap.CenterOrigin();
            spritemap.AddAnimation("expl1", new Point(0, 0), 16, 0.4f, false);
            spritemap.AddAnimation("expl2", new Point(0, 64), 16, 0.4f, true);

            BaseGameComponent baseGameComponent = new BaseGameComponent(this, spritemap, 200, 100, 64, 64);
            spritemap.PlayAnimation("expl2");

            AddComponent(baseGameComponent);
            

            //
            SpriteFont spriteFont = Commons.Content.Load<SpriteFont>("Fonts/Pericles");

            _labelPlay = new ClickableLabel(Commons.Game, "Play", spriteFont, new Vector2(100, 100),
                new Action(() => spritemap.PlayAnimation("expl1")));
            
            _labelExit = new ClickableLabel(Commons.Game, "Exit", spriteFont, new Vector2(100, 200),
                new Action(() => spritemap.PlayAnimation("expl2")));
            
            AddComponent(_labelPlay);
            AddComponent(_labelExit);
           */

            /*
            Texture2D texture2D = Commons.Content.Load<Texture2D>("Textures/Enemy");
            Image image = new Image(texture2D);
            //image.CenterOrigin();
            image.SetOverlayColor(Color.Red);
            image.SetScaleByValue(1.0f);
            //image.SetSpriteEffect(SpriteEffects.FlipVertically);

            BaseGameComponent test = new BaseGameComponent(this, image, 100, 100, 32, 32);

            AddComponent(test);
                */
            /*
            Texture2D texture2D = Commons.Content.Load<Texture2D>("Textures/Test");
            Background bg = new Background(texture2D, Commons.GraphicsDevice.Viewport.Width, Commons.GraphicsDevice.Viewport.Height);
            bg.StretchVertical = true;
            bg.StretchHorizontal = true;
            bg.X = 100;
            AddComponent(bg);
            */
            


            return base.Initialize();
        }

       
        internal override void OnUpdate(GameTime gameTime)
        {


            base.OnUpdate(gameTime);
        }
    }
}
