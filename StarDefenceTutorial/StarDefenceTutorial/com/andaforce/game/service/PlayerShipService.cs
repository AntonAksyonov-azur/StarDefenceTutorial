using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StarDefenceTutorial.com.andaforce.axna.graphics;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.entity;

namespace StarDefenceTutorial.com.andaforce.game.service
{
    public class PlayerShipService : AbstractSpawnService
    {
        private readonly Texture2D _death;
        private readonly Texture2D _idle;
        private readonly Texture2D _move;
        private PlayerShip _currentPlayerShip;

        public PlayerShipService(Screen parentScreen, Texture2D idle, Texture2D move, Texture2D death) : base(parentScreen)
        {
            _idle = idle;
            _move = move;
            _death = death;
        }

        public override void CreateEntity()
        {
            _currentPlayerShip = new PlayerShip(100, 100, 72, 16);

            var playerIdle = new Image(_idle);
            var playerMove = new Image(_move);

            var playerDeath = new Spritemap(_death, 64, 64);
            playerDeath.AddAnimation(EntityState.Death, new Point(0, 0), 16, 16.0f);
            playerDeath.X = -10;
            playerDeath.Y = -15;

            _currentPlayerShip.SetUpGraphics(playerIdle, playerMove, playerDeath);
            _currentPlayerShip.Velocity = 100;
            _currentPlayerShip.MaxHorizontalSpeed = 2.0f;
            _currentPlayerShip.HorizontalAcceleration = 0.15f;

            ParentScreen.AddComponent(_currentPlayerShip);
        }

        public void SetPlayerShipVelocity(int velocity)
        {
            _currentPlayerShip.Velocity = velocity;
        }
    }
}