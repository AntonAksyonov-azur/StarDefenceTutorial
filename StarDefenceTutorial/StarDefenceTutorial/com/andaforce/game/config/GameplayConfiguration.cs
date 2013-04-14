namespace StarDefenceTutorial.com.andaforce.game.config
{
    public class GameplayConfiguration
    {
        public int ScoresByHit = 1;
        public int ScoresByDeath = -10;
        public int ScoreModifierByLevel = 1;

        public float ScrollSpeed = 1;
        public float ScrollModifierByLevel = 0.5f;

        public int BaseEnemiesCount = 5;
        public int AdditionalEnemiesByLevel = 5;
        public int BaseMaxEnemiesSpeed = 140;
        public int EnemiesSpeedInscreasingByLevel = 10;

        public int HitsToChangeLevel = 10;
    }
}
