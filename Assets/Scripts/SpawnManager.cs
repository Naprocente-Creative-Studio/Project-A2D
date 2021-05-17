using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public GameObject[] asteroidShardsPrefabs;
    public GameObject[] lightPrefabs;
    private readonly float[] spawnFixPosX = {-1.8f, -0.6f, 0.6f, 1.8f};
    private float[] spawnLightPosX = { -3f, 3f };
    private float spawnPosY = 11, spawnPosYL = 17;
    private float startDelay = 2, startDelayL = 8;
    private float spawnInterval = 1.5f, spawnIntervalL = 18;
    private PlayerController playerScript;
    private GameController _gameController;
    
    private void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
        InvokeRepeating("spawnRandomAsteroid", startDelay, spawnInterval);
        InvokeRepeating("spawnLights", startDelayL, spawnIntervalL);
    }

    private void FixedUpdate()
    {
        if (playerScript.gameIsOver || _gameController.gameIsPaused)
        {
            CancelInvoke("spawnRandomAsteroid");
            CancelInvoke("spawnLights");
        }
    }

    void spawnRandomAsteroid()
    {
        int astIndex = Random.Range(0, asteroidPrefabs.Length);
        Vector2 spawnPos = new Vector2(spawnFixPosX[Random.Range(0, spawnFixPosX.Length)], spawnPosY);

        Instantiate(asteroidPrefabs[astIndex], spawnPos, asteroidPrefabs[astIndex].transform.rotation);
    }

    void spawnLights()
    {
        int lightIndex = Random.Range(0, lightPrefabs.Length);
        Vector2 spawnPos = new Vector2(spawnLightPosX[Random.Range(0, spawnLightPosX.Length)], spawnPosYL);

        Instantiate(lightPrefabs[lightIndex], spawnPos, lightPrefabs[lightIndex].transform.rotation);
    }

    public void ResumeSpawn()
    {
        InvokeRepeating("spawnRandomAsteroid", startDelay, spawnInterval);
        InvokeRepeating("spawnLights", startDelayL, spawnIntervalL);
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
