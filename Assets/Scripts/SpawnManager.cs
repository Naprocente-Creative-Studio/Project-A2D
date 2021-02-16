using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    private float spawnPosX = 6;
    private float spawnPosY = 6;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private PlayerController playerScript;
    
    private void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("spawnRandomAsteroid", startDelay, spawnInterval);
    }

    private void FixedUpdate()
    {
        if(playerScript.gameIsOver) CancelInvoke("spawnRandomAsteroid");
    }

    void spawnRandomAsteroid()
    {
        int astIndex = Random.Range(0, asteroidPrefabs.Length);
        float rotZ = Random.Range(0f, 180f);
        asteroidPrefabs[astIndex].transform.Rotate(0f, 0f, rotZ, Space.World);
        Vector2 spawnPos = new Vector2(Random.Range(-spawnPosX, spawnPosX), spawnPosY);

        Instantiate(asteroidPrefabs[astIndex], spawnPos, asteroidPrefabs[astIndex].transform.rotation);
    }
}
