using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SystemGenerator : MonoBehaviour
{
    public GameObject[] starPrefabs;
    public GameObject[] planetPrefabs;
    private Vector3 starPos = new Vector3(-2.35f, 0.42f, 0);
    private void Awake()
    {
        SpawnStarOnStart();
        SpawnPlanetSystem();
    }

    void SpawnStarOnStart()
    {
        int randomIndex = Random.Range(0, starPrefabs.Length);
        Instantiate(starPrefabs[randomIndex], starPos, transform.rotation);
    }

    void SpawnPlanetSystem()
    {
        int randomCount = Random.Range(1, 5);
        for (int i = 0; i <= randomCount; i++)
        {
            int randomIndex = Random.Range(0, planetPrefabs.Length);
            Vector3 planetPos = RandomCircle(starPos, i + 2);
            Instantiate(planetPrefabs[randomIndex], planetPos, transform.rotation);
            Debug.Log(planetPos);
        }
    }

    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 180;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
}
