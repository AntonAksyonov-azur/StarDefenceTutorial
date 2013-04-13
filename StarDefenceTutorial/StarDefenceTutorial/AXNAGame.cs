using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using StarDefenceTutorial.com.andaforce.game.screens;

namespace StarDefenceTutorial
{
    public class AXNAGame : Microsoft.Xna.Framework.Game
    {
        protected readonly GraphicsDeviceManager Graphics;

        public AXNAGame(int width, int height, bool isMouseVisible = true)
        {
            Graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            Graphics.PreferredBackBufferWidth = width;
            Graphics.PreferredBackBufferHeight = height;
            Graphics.ApplyChanges();

            IsMouseVisible = isMouseVisible;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            AXNA.Game = this;
            AXNA.Content = Content;
            AXNA.GraphicsDevice = Graphics.GraphicsDevice;
            AXNA.SpriteBatch = new SpriteBatch(Graphics.GraphicsDevice);
        }

        protected override void UnloadContent()
        {
        }


        protected override void Update(GameTime gameTime)
        {
            InputManager.Update(gameTime);
            ScreenManager.Update(gameTime);

            Window.Title = String.Format("X: {0}, Y: {1}", InputManager.GetMouseX(), InputManager.GetMouseY());

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            ScreenManager.Draw(gameTime);
        }
    }
}
