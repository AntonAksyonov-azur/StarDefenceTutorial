using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.entity.background;
using StarDefenceTutorial.com.andaforce.axna.graphics;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using StarDefenceTutorial.com.andaforce.axna.ui;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.service;
using StarDefenceTutorial.com.andaforce.game.service.gameplay;
using StarDefenceTutorial.com.andaforce.game.service.observer;

namespace StarDefenceTutorial.com.andaforce.game.screens
{
    public class GameScreen : Screen
    {
        private ParallaxBackground _background;

        internal GameScreen()
            : base(ScreenNames.Game)
        {
        }

        internal override bool Initialize()
        {
            InitializeBackgroung();

            InitializePlayerShip();

            InitializeEnemies();

            InitializeGamePlay();

            return base.Initialize();
        }

        private void InitializeGamePlay()
        {
            var gameplayService = new GameplayService();
            gameplayService.Reset();
            gameplayService.RemoveAllObservers();
            AXNA.Game.Services.RemoveService(typeof(GameplayService));

            var spriteFont = AXNA.Content.Load<SpriteFont>("Fonts/Pericles");

            var level = new TextString(gameplayService.GetLevelString(), spriteFont);
            var labelLevel = new TextLabel(level, 10, 10);
            gameplayService.AddObserver(ObserverNames.CurrentLevel, labelLevel);
            AddComponent(labelLevel);

            var lives = new TextString(gameplayService.GetPlayerLivesString(), spriteFont);
            var labelLives = new TextLabel(lives, 120, 10);
            gameplayService.AddObserver(ObserverNames.PlayerLives, labelLives);
            AddComponent(labelLives);

            var scoresTextString = new TextString(gameplayService.GetScoreString(), spriteFont);
            var labelScores = new TextLabel(scoresTextString, 220, 10);
            gameplayService.AddObserver(ObserverNames.Score, labelScores);
            AddComponent(labelScores);

            var acuracy = new TextString(gameplayService.GetShootingStatisticString(), spriteFont);
            var labelAccuracy = new TextLabel(acuracy, 10, 30);
            gameplayService.AddObserver(ObserverNames.Accuracy, labelAccuracy);
            AddComponent(labelAccuracy);

            var time = new TextString(gameplayService.GetTotalTimeString(), spriteFont);
            var labelTime = new TextLabel(time, 10, 50);
            gameplayService.AddObserver(ObserverNames.TotalTime, labelTime);
            AddComponent(labelTime);

            var centerMessage = new TextString("", spriteFont);
            var labelCenterMessage = new TextLabel(centerMessage, AXNA.GraphicsDevice.Viewport.Width/2 - 100,
                                                   AXNA.GraphicsDevice.Viewport.Height/2 - 20);
            gameplayService.AddObserver(ObserverNames.CenterMessage, labelCenterMessage);
            AddComponent(labelCenterMessage);

            AXNA.Game.Services.AddService(typeof (GameplayService), gameplayService);
        }

        private void InitializePlayerShip()
        {
            var existedPlayerShipService =
                AXNA.Game.Services.GetService(typeof (PlayerShipService)) as PlayerShipService;
            if (existedPlayerShipService == null)
            {
                var playerIdle = AXNA.Content.Load<Texture2D>("Textures/PlayerShip/idle");
                var playerMove = AXNA.Content.Load<Texture2D>("Textures/PlayerShip/move");
                var playerDeath = AXNA.Content.Load<Texture2D>("Textures/PlayerShip/death");
                var playerShipService = new PlayerShipService(this, playerIdle, playerMove, playerDeath);
                AXNA.Game.Services.AddService(typeof (PlayerShipService), playerShipService);

                existedPlayerShipService = playerShipService;
            }
            existedPlayerShipService.CreateEntity();

            var existedBulletService =
                AXNA.Game.Services.GetService(typeof (BulletService)) as BulletService;
            if (existedBulletService == null)
            {
                var bulletMoveLeft = AXNA.Content.Load<Texture2D>("Textures/PlayerShip/Bullet/left");
                var bulletMoveRight = AXNA.Content.Load<Texture2D>("Textures/PlayerShip/Bullet/right");
                var bulletService = new BulletService(this, bulletMoveLeft, bulletMoveRight);
                AXNA.Game.Services.AddService(typeof (BulletService), bulletService);

                bulletService.BulletShootInterval = 0.3f;
            }
        }

        private void InitializeEnemies()
        {
            var existedEnemyService =
                AXNA.Game.Services.GetService(typeof (EnemyService)) as EnemyService;
            if (existedEnemyService == null)
            {
                var enemyMove = AXNA.Content.Load<Texture2D>("Textures/Enemy/move");
                var enemyDeath = AXNA.Content.Load<Texture2D>("Textures/Enemy/death");

                var enemyService = new EnemyService(this, enemyMove, enemyDeath);
                AXNA.Game.Services.AddService(typeof (EnemyService), enemyService);

                existedEnemyService = enemyService;
            }
            else
            {
                existedEnemyService.Reset();
            }
            existedEnemyService.CreateEnemy();
        }

        // TODO Загружать текстуры заднего плана один раз, не перезагружать при повторном запуске игры
        private void InitializeBackgroung()
        {
            var spaceTexture = AXNA.Content.Load<Texture2D>("Textures/PrimaryBackground");
            var stars = AXNA.Content.Load<Texture2D>("Textures/ParallaxStars");

            var spaceParallax = new ParallaxTexture(spaceTexture, true, 2);
            var starsParallax = new ParallaxTexture(stars, true, 4);
            _background = new ParallaxBackground(spaceParallax, AXNA.GraphicsDevice.Viewport.Width,
                                                 AXNA.GraphicsDevice.Viewport.Height);
            _background.Textures.Add(starsParallax);

            /*
            ParallaxTexture starsParallax2 = new ParallaxTexture(stars, true, 8);
            starsParallax2.Y = 50;
            background.Textures.Add(starsParallax2);
            */

            AddComponent(_background);
        }

        internal override void OnUpdate(GameTime gameTime)
        {
            base.OnUpdate(gameTime);

            var bulletService = AXNA.Game.Services.GetService(typeof (BulletService)) as BulletService;
            if (bulletService != null) bulletService.UpdateService(gameTime);

            var gameplayService = AXNA.Game.Services.GetService(typeof (GameplayService)) as GameplayService;
            if (gameplayService != null)
            {
                gameplayService.UpdateService(gameTime);

                _background.Move(-gameplayService.GetScrollSpeedBasedOnLevel(), 0);

                var enemyService = AXNA.Game.Services.GetService(typeof (EnemyService)) as EnemyService;
                if (enemyService != null)
                {
                    enemyService.UpdateService(gameTime);
                    enemyService.MoveEnemies(-gameplayService.GetScrollSpeedBasedOnLevel());
                }
            }
        }
    }
}