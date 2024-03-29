﻿using System;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.graphics;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using StarDefenceTutorial.com.andaforce.axna.ui;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.service.gameplay;

namespace StarDefenceTutorial.com.andaforce.game.screens
{
    public class RecordsScreen : Screen
    {
        internal RecordsScreen() : base(ScreenNames.Rerords)
        {
        }

        internal override bool Initialize()
        {
            var spriteFont = AXNA.Content.Load<SpriteFont>("Fonts/Pericles");

            var caption = new TextString("This is a records screen", spriteFont);
            var labelCaption = new TextLabel(caption, 10, 10);
            AddComponent(labelCaption);

            var gameplayService = AXNA.Game.Services.GetService(typeof (GameplayService)) as GameplayService;
            if (gameplayService != null)
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.Append(String.Format("You survived for {0:f0} seconds total", gameplayService.ElapsedGameTime));
                stringBuilder.Append(String.Format("\nYou killed {0} enemies with {1} shots total ({2} accuracy)", gameplayService.TotalHits,
                                             gameplayService.TotalShots, gameplayService.GetAccuracyString()));
                stringBuilder.Append(String.Format("\nYou reached level {0}", gameplayService.Level));
                stringBuilder.Append(String.Format("\nYou scored {0}", gameplayService.Score));

                stringBuilder.Append(String.Format("\n\nYour total score is: {0}", gameplayService.GetTotalScoreString()));

                var recordText = new TextString(stringBuilder.ToString(), spriteFont);
                var labelRecordText = new TextLabel(recordText, 10, 40);
                AddComponent(labelRecordText);

            }

            var continueText = new TextString("Press [Enter] to try again", spriteFont);
            var labelContinue = new TextLabel(continueText, 10, 400);
            AddComponent(labelContinue);

            return base.Initialize();
        }

        internal override void OnUpdate(GameTime gameTime)
        {
            base.OnUpdate(gameTime);

            if (InputManager.IsKeyPressed(Keys.Enter))
            {
                ScreenManager.ActivateScreenByName(ScreenNames.Game);
            }
        }
    }
}
