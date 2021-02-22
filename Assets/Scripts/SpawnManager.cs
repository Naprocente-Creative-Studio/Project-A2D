using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public GameObject[] asteroidShardsPrefabs;
    private float spawnPosX = 3;
    private float spawnPosY = 11;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private PlayerController playerScript;
    private GameController _gameController;
    
    private void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
        InvokeRepeating("spawnRandomAsteroid", startDelay, spawnInterval);
    }

    private void FixedUpdate()
    {
        if(playerScript.gameIsOver || _gameController.gameIsPaused) CancelInvoke("spawnRandomAsteroid");
    }

    void spawnRandomAsteroid()
    {
        int astIndex = Random.Range(0, asteroidPrefabs.Length);
        Vector2 spawnPos = new Vector2(Random.Range(-spawnPosX, spawnPosX), spawnPosY);

        Instantiate(asteroidPrefabs[astIndex], spawnPos, asteroidPrefabs[astIndex].transform.rotation);
    }

    public void ResumeSpawnAsteroids()
    {
        InvokeRepeating("spawnRandomAsteroid", startDelay, spawnInterval);
    }

    public void SpawnShardsAsteroids(Vector2 crashPos)
    {
        int countShards = Random.Range(1, 2);
        for (int i = 0; i <= countShards; i++)
        {
            int astIndex = Random.Range(0, asteroidShardsPrefabs.Length);
            Vector2 startPos = new Vector2(crashPos.x + Random.Range(-0.5f, 0.5f), crashPos.y + Random.Range(-0.5f, 0.5f));
            Quaternion startRot = Quaternion.Euler(0, 0, Random.Range(-180, 180));
            Instantiate(asteroidShardsPrefabs[astIndex], startPos, transform.rotation * startRot);
        }
       
    }
}
