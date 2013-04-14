using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.graphics;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using StarDefenceTutorial.com.andaforce.game.config;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.entity;
using StarDefenceTutorial.com.andaforce.game.service.gameplay;

namespace StarDefenceTutorial.com.andaforce.game.service
{
    public class BulletService : AbstractSpawnService
    {
        public Texture2D LeftBulletGraphics;
        public Texture2D RightBulletGraphics;
        private int _bulletElapsedShootTime = int.MaxValue; // Для того, чтобы первое нажатие сразу выпустило пулю
        private int _bulletShootInterval;
        private bool _isTripleMode;
        private bool _playerShipLeftOrientation;
        private Vector2 _playerShipPosition;

        public BulletService(Screen parentScreen,
                             Texture2D leftBulletGraphics, Texture2D rightBulletGraphics) : base(parentScreen)
        {
            LeftBulletGraphics = leftBulletGraphics;
            RightBulletGraphics = rightBulletGraphics;

            _bulletShootInterval = Configuration.Get().BulletConfiguration.ShootInterval;
        }

        public override void CreateEntity()
        {
            var img = new Image(_playerShipLeftOrientation ? LeftBulletGraphics : RightBulletGraphics);
            int speed = _playerShipLeftOrientation
                            ? -Configuration.Get().BulletConfiguration.BulletVelocity
                            : Configuration.Get().BulletConfiguration.BulletVelocity;

            ParentScreen.AddComponent(CreateBullet(_playerShipPosition.Y, speed, img));

            if (_isTripleMode)
            {
                ParentScreen.AddComponent(CreateBullet(_playerShipPosition.Y - 10, speed, img));
                ParentScreen.AddComponent(CreateBullet(_playerShipPosition.Y + 10, speed, img));
            }
        }

        private Bullet CreateBullet(float y, int speed, Image img)
        {
            var bullet = new Bullet(_playerShipPosition.X, y, 16, 1, speed);
            bullet.SetUpGraphics(img, img, img, EntityState.Move);
            return bullet;
        }

        public override void UpdateService(GameTime gameTime)
        {
            _bulletElapsedShootTime += _bulletElapsedShootTime < _bulletShootInterval ? gameTime.ElapsedGameTime.Milliseconds : 0;
        }

        public void TryShoot(PlayerShip playerShip)
        {
            if (_bulletElapsedShootTime >= _bulletShootInterval)
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

        public void SetFirerate(int firerate)
        {
            _bulletShootInterval = firerate;
        }

        public void SetTripleMode(bool isTripleMode)
        {
            _isTripleMode = isTripleMode;
        }

        //
    }
}