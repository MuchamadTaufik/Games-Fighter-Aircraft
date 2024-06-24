namespace Agate.SpaceShooter
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        [SerializeField] private Enemy _enemyPrefab;
        [SerializeField] private int _enemyCount;
        [SerializeField] private float _enemySpawnRange;
        [SerializeField] private Coin _CoinPrefab;
        [SerializeField] private int _CointCount;
        [SerializeField] private float _CoinSpawnRange;
    }
}

private void Start()
{
    SpawnEnemies();
    
}