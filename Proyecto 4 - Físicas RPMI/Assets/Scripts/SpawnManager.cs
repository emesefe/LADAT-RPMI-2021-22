using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnPositionRange = 9f;
    
    void Start()
    {
       
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
}
