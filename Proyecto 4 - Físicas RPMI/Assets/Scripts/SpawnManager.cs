using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;

    private float spawnPositionRange = 9f;

    private int enemiesPerWave = 1;
    private int enemiesLeft;
    
    void Start()
    {
        Instantiate(powerUpPrefab, RandomSpawnPostion(),
            powerUpPrefab.transform.rotation);
        SpawnEnemyWave(enemiesPerWave);
    }

    private void Update()
    {
        enemiesLeft = FindObjectsOfType<Enemy>().Length;
        if (enemiesLeft <= 0)
        {
            enemiesPerWave++;
            SpawnEnemyWave(enemiesPerWave);
            Instantiate(powerUpPrefab, RandomSpawnPostion(),
                powerUpPrefab.transform.rotation);
        }
    }

    private Vector3 RandomSpawnPostion()
    {
        float xRandom = Random.Range(-spawnPositionRange, spawnPositionRange);
        float zRandom = Random.Range(-spawnPositionRange, spawnPositionRange);
        
        return new Vector3(xRandom, 0, zRandom);
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, RandomSpawnPostion(), enemyPrefab.transform.rotation);
    }

    private void SpawnEnemyWave(int totalEnemies)
    {
        for (int i = 0; i < totalEnemies; i++)
        {
            SpawnEnemy();
        }
    }
}
