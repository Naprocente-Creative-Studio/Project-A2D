using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    private float spawnPosX = 3;
    private float spawnPosY = 6;
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
        float rotZ = Random.Range(0f, 180f);
        Vector2 spawnPos = new Vector2(Random.Range(-spawnPosX, spawnPosX), spawnPosY);

        Instantiate(asteroidPrefabs[astIndex], spawnPos, asteroidPrefabs[astIndex].transform.rotation);
    }

    public void ResumeSpawnAsteroids()
    {
        InvokeRepeating("spawnRandomAsteroid", startDelay, spawnInterval);
    }
}
