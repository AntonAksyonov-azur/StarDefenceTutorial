using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using StarDefenceTutorial.com.andaforce.axna;
using StarDefenceTutorial.com.andaforce.axna.screen.manager;
using StarDefenceTutorial.com.andaforce.game.constants;
using StarDefenceTutorial.com.andaforce.game.service.observer;

namespace StarDefenceTutorial.com.andaforce.game.service.gameplay
{
    public class GameplayService : AbstractService
    {
        private readonly Dictionary<ObserverNames, ITextObserver> _observers =
            new Dictionary<ObserverNames, ITextObserver>();

        public int HitsToNextLevel = 10;

        private GameplayState _currentGameplayState;
        private int _hitsRemainingForNextLevel = 10;

        public double ElapsedGameTime { get; private set; }
        public int PlayerLives { get; private set; }
        public int Score { get; private set; }

        public int TotalHits { get; private set; }

        public int TotalShots { get; private set; }
        public int Level { get; private set; }

        #region Управляющие функции

        public void ChangeGameplayState(GameplayState gameplayState)
        {
            if (_currentGameplayState != gameplayState)
            {
                _currentGameplayState = gameplayState;

                switch (_currentGameplayState)
                {
                    case GameplayState.Play:
                        _observers[ObserverNames.CenterMessage].UpdateTextParameter(String.Empty);
                        break;
                    case GameplayState.PlayerIsDestroyed:
                        _observers[ObserverNames.CenterMessage].UpdateTextParameter("Press [ENTER] to continue!");
                        break;
                    case GameplayState.PlayerIsLosses:
                        _observers[ObserverNames.CenterMessage].UpdateTextParameter(
                            "GAME OVER!\nPress [ENTER] to save your score");
                        break;
                }
            }
        }

        public override void UpdateService(GameTime gameTime)
        {
            ElapsedGameTime += AXNA.GetTimeIntervalValue(gameTime);
            _observers[ObserverNames.TotalTime].UpdateTextParameter(GetTotalTimeString());

            switch (_currentGameplayState)
            {
                case GameplayState.Play:
                    break;
                case GameplayState.PlayerIsDestroyed:
                    if (InputManager.IsKeyPressed(Keys.Enter))
                    {
                        var playerShipService =
                            AXNA.Game.Services.GetService(typeof (PlayerShipService)) as PlayerShipService;
                        if (playerShipService != null)
                        {
                            playerShipService.CreateEntity();
                            ChangeGameplayState(GameplayState.Play);
                        }
                    }
                    break;
                case GameplayState.PlayerIsLosses:
                    if (InputManager.IsKeyPressed(Keys.Enter))
                    {
                        ScreenManager.ActivateScreenByName(ScreenNames.Rerords);
                    }
                    break;
            }
        }

        public void Reset()
        {
            TotalShots = 0;
            TotalHits = 0;

            Score = 0;

            PlayerLives = 3;
            ElapsedGameTime = 0;
            Level = 1;
        }

        #endregion

        #region Наблюдатель

        public void AddObserver(ObserverNames name, ITextObserver observer)
        {
            _observers.Add(name, observer);
        }

        public void RemoveAllObservers()
        {
            _observers.Clear();
        }

        #endregion

        #region Модификации значений с обновлением наблюдателей

        public void AddHit()
        {
            TotalHits += 1;
            _observers[ObserverNames.Accuracy].UpdateTextParameter(GetShootingStatisticString());

            _hitsRemainingForNextLevel -= 1;
            if (_hitsRemainingForNextLevel == 0)
            {
                ChangeLevel(Level + 1);
                _hitsRemainingForNextLevel = HitsToNextLevel;
            }
        }

        public void AddShot()
        {
            TotalShots += 1;
            _observers[ObserverNames.Accuracy].UpdateTextParameter(GetShootingStatisticString());
        }

        public void ChangeScore(int scoreChange)
        {
            Score += scoreChange;
            _observers[ObserverNames.Score].UpdateTextParameter(GetScoreString());
        }

        public void AddScoreForHit()
        {
            ChangeScore(GetScoresForEnemiesBasedOnLevel());
        }

        public void ReduceScoreForDeath()
        {
            ChangeScore(GetPlayerdeathScoreBasedOnLevel());
        }

        public void ChangePlayerLives(int playerLivesChange)
        {
            int oldPlayerLives = PlayerLives;

            PlayerLives += playerLivesChange;
            _observers[ObserverNames.PlayerLives].UpdateTextParameter(GetPlayerLivesString());

            if (PlayerLives == 0)
            {
                ChangeGameplayState(GameplayState.PlayerIsLosses);
            }
            else if (PlayerLives < oldPlayerLives)
            {
                ChangeGameplayState(GameplayState.PlayerIsDestroyed);
            }
        }

        public void ChangeLevel(int level)
        {
            Level = level;
            _observers[ObserverNames.CurrentLevel].UpdateTextParameter(GetLevelString());
        }

        #endregion

        #region Строковые представления переменных

        public String GetShootingStatisticString()
        {
            if (TotalShots > 0)
            {
                return String.Format("Shots: {0}, Hits: {1}, Accuracy: {2:f2}%", TotalShots, TotalHits,
                                     (float) TotalHits/TotalShots*100);
            }

            return "Shots: 0, Hits: 0, Accuracy: 100%";
        }

        public String GetAccuracyString()
        {
            if (TotalShots > 0)
            {
                return String.Format("{0:f2}%", (float) TotalHits/TotalShots*100);
            }

            return "100%";
        }

        public String GetTotalTimeString()
        {
            return String.Format("Total time: {0:f0}", ElapsedGameTime);
        }

        public String GetScoreString()
        {
            return String.Format("Score: {0}", Score);
        }

        public String GetPlayerLivesString()
        {
            return String.Format("Lives: {0}", PlayerLives);
        }

        public String GetLevelString()
        {
            return String.Format("Level: {0}", Level);
        }

        public String GetTotalScoreString()
        {
            float accuracy = TotalShots == 0 ? 1 : (float) TotalHits/TotalShots;
            return String.Format("{0:f2}", Score + Score*accuracy);
        }

        #endregion

        #region Изменения игровой логики в зависимости от текущего уровня

        public int GetScrollSpeedBasedOnLevel()
        {
            return Level;
        }

        public int GetEnemiesCountBasedOnLevel()
        {
            return Level*5;
        }

        public int GetEnemiesSpeedBasedOnLevel()
        {
            return 140 + Level*10;
        }

        public int GetScoresForEnemiesBasedOnLevel()
        {
            return Level;
        }

        public int GetPlayerdeathScoreBasedOnLevel()
        {
            return -Level*10;
        }

        #endregion
    }
}