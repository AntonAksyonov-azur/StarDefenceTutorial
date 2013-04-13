using System.Collections.Generic;
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
    public class EnemyService : AbstractSpawnService
    {
        private const float EnemyAppearsInterval = 0.5f;
        private readonly List<Enemy> _enemies = new List<Enemy>();
        public Texture2D EnemyGraphicsDeath;
        public Texture2D EnemyGraphicsMove;
        private float _enemyElapsedTime;

        public EnemyService(Screen parentScreen, Texture2D moveGraphics, Texture2D deathGraphics) : base(parentScreen)
        {
            EnemyGraphicsMove = moveGraphics;
            EnemyGraphicsDeath = deathGraphics;
        }

        public void Reset()
        {
            _enemies.Clear();
        }

        public override void CreateEntity()
        {
            var gameplayService = AXNA.Game.Services.GetService(typeof (GameplayService)) as GameplayService;
            if (gameplayService != null)
            {
                int enemyMaxSpeed = gameplayService.GetEnemiesSpeedBasedOnLevel();

                var enemy = new Enemy(
                    Configuration.GetInstance().ScreenWidth,
                    AXNA.Rnd.Next(0, Configuration.GetInstance().ScreenHeight),
                    24, 24,
                    new Vector2(
                        AXNA.Rnd.Next(-enemyMaxSpeed, enemyMaxSpeed),
                        AXNA.Rnd.Next(-enemyMaxSpeed, enemyMaxSpeed)));

                enemy.Hitbox.X = -8;
                enemy.Hitbox.Y = -8;

                var enemyMove = new Image(EnemyGraphicsMove);
                enemyMove.CenterOrigin();
                enemyMove.X = -12;
                enemyMove.Y = -12;

                enemyMove.SetRotationAngleByDegrees(AXNA.Rnd.Next(0, 360));
                var enemyDeath = new Spritemap(EnemyGraphicsDeath, 64, 64);
                enemyDeath.X = -24;
                enemyDeath.Y = -24;
                enemyDeath.AddAnimation(EntityState.Death, new Point(0, 64), 16, 16.0f);
                enemy.SetUpGraphics(enemyMove, enemyMove, enemyDeath, EntityState.Move);

                ParentScreen.AddComponent(enemy);
                _enemies.Add(enemy);
            }
        }

        public override void UpdateService(GameTime gameTime)
        {
            var gameplayService = AXNA.Game.Services.GetService(typeof (GameplayService)) as GameplayService;
            if (gameplayService != null)
            {
                if (_enemies.Count < gameplayService.GetEnemiesCountBasedOnLevel())
                {
                    if (_enemyElapsedTime > EnemyAppearsInterval)
                    {
                        CreateEntity();
                        _enemyElapsedTime = 0;
                    }
                    else
                    {
                        _enemyElapsedTime += (float) gameTime.ElapsedGameTime.Milliseconds/1000;
                    }
                }
            }
        }

        public void MoveEnemies(int scrollSpeed)
        {
            foreach (Enemy e in _enemies)
            {
                e.Position.X += scrollSpeed;
            }
        }

        public void RemoveEnemy(Enemy e)
        {
            _enemies.Remove(e);
        }

        //
    }
}