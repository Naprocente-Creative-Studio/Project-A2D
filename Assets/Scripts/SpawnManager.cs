using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public GameObject[] asteroidShardsPrefabs;
    public GameObject[] lightPrefabs;
    private readonly float[] spawnFixPosX = {-1.8f, -0.6f, 0.6f, 1.8f};
    public int[] Ratio_Chances;
    private float[] spawnLightPosX = { -3f, 3f };
    private float spawnPosY = 11, spawnPosYL = 17;
    private float startDelay = 2, startDelayL = 8;
    public float spawnInterval = 1.5f, spawnIntervalL = 18;
    public GameObject playController;
    public float speed;
    private int Ratio_Final = 0;
    IEnumerator spawner;

    private void Start()
    {
        spawner = spawnRandomAsteroid(startDelay);
        for (int i = 0; i < Ratio_Chances.Length; i++)
        {
            Ratio_Final += Ratio_Chances[i];
        }
        StartCoroutine(spawner);
        InvokeRepeating("spawnLights", startDelayL, spawnIntervalL);
        InvokeRepeating("decreaseDelay", 10, 1);
        InvokeRepeating("IncreaseSpeed", 8, 10);
    }

    private void FixedUpdate()
    {
        if (playController.GetComponent<GamePlayController>().gameOverTrigger || playController.GetComponent<GamePlayController>().pauseTrigger)
        {
            StopCoroutine(spawner);
            CancelInvoke("spawnLights");
            CancelInvoke("decreaseDelay");
            CancelInvoke("IncreaseSpeed");
        }
        if (!playController.GetComponent<GamePlayController>().gameOverTrigger && !playController.GetComponent<GamePlayController>().pauseTrigger && IsInvoking("IncreaseSpeed") && speed > 15) CancelInvoke("IncreaseSpeed");
        if (!playController.GetComponent<GamePlayController>().gameOverTrigger && !playController.GetComponent<GamePlayController>().pauseTrigger && IsInvoking("decreaseDelay") && spawnInterval < 0.6f) CancelInvoke("decreaseDelay");
    }

    IEnumerator spawnRandomAsteroid(float startDelay)
    {
        yield return new WaitForSeconds(startDelay);
        while (true)
        {
            int astIndex = RandomAst();
            Vector2 spawnPos = new Vector2(spawnFixPosX[Random.Range(0, spawnFixPosX.Length)], spawnPosY);

            GameObject ast = Instantiate(asteroidPrefabs[astIndex], spawnPos, asteroidPrefabs[astIndex].transform.rotation);
            ast.GetComponent<MoveDown>().speed += speed;
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void spawnLights()
    {
        int lightIndex = Random.Range(0, lightPrefabs.Length);
        Vector2 spawnPos = new Vector2(spawnLightPosX[Random.Range(0, spawnLightPosX.Length)], spawnPosYL);

        Instantiate(lightPrefabs[lightIndex], spawnPos, lightPrefabs[lightIndex].transform.rotation);
    }

    public void ResumeSpawn()
    {
        StartCoroutine(spawner);
        InvokeRepeating("spawnLights", startDelayL, spawnIntervalL);
        if (spawnInterval > 0.5f) InvokeRepeating("decreaseDelay", 10, 1);
        if (speed < 10) InvokeRepeating("IncreaseSpeed", 8, 10);
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
    public void decreaseDelay()
    {
        spawnInterval -= 0.01f;
    }

    private void IncreaseSpeed()
    {
        speed += 0.05f;
    }

    public int RandomAst()
    {
        int x = Random.Range(0, Ratio_Final);
        for (int i = 0; i < Ratio_Chances.Length; i++)
        {
            if ((x -= Ratio_Chances[i]) < 0) return i;
        }
        return 0;
    }
}
