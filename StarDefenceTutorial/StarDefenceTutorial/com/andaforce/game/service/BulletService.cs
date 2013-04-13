﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.graphics;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.entity;
using StarDefenceTutorial.com.andaforce.game.service.gameplay;

namespace StarDefenceTutorial.com.andaforce.game.service
{
    public class BulletService : AbstractSpawnService
    {
        public float BulletShootInterval;
        public Texture2D LeftBulletGraphics;
        public Texture2D RightBulletGraphics;
        private float _bulletElapsedShootTime = 999; // Для того, чтобы первое нажатие сразу выпустило пулю
        private bool _playerShipLeftOrientation;
        private Vector2 _playerShipPosition;

        public BulletService(Screen parentScreen,
                             Texture2D leftBulletGraphics, Texture2D rightBulletGraphics)
        {
            LeftBulletGraphics = leftBulletGraphics;
            RightBulletGraphics = rightBulletGraphics;
            ParentScreen = parentScreen;
        }

        public override void CreateEntity()
        {
            var img = new Image(_playerShipLeftOrientation ? LeftBulletGraphics : RightBulletGraphics);
            var bullet = new Bullet(
                _playerShipPosition.X, _playerShipPosition.Y,
                16, 1,
                _playerShipLeftOrientation ? -300 : 300);

            bullet.SetUpGraphics(img, img, img, EntityState.Move);

            ParentScreen.AddComponent(bullet);
        }

        public override void UpdateService(GameTime gameTime)
        {
            _bulletElapsedShootTime += AXNA.GetTimeIntervalValue(gameTime);
        }

        public void TryShoot(PlayerShip playerShip)
        {
            if (_bulletElapsedShootTime >= BulletShootInterval)
            {
                _playerShipPosition = new Vector2(playerShip.GetEntityRectangle().Center.X,
                                                  playerShip.GetEntityRectangle().Center.Y);
                _playerShipLeftOrientation = playerShip.LeftOrientation;

                CreateEntity();

                var gameplayService =
                    AXNA.Game.Services.GetService(typeof (GameplayService)) as GameplayService;
                if (gameplayService != null) gameplayService.AddShot();

                _bulletElapsedShootTime = 0;
            }
        }

        //
    }
}