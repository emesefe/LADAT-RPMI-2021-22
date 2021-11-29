using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private Vector3 spawnPosition;
    private float xRange = 15f;
    private float spawnZ = 25f;
    private float startTime = 2f;
    private float repeatRate = 1.5f;
    private float randomX;
    private int randomIndex;
    

    void Start()
    {
        InvokeRepeating("SpawnAnimal", startTime, repeatRate);
    }
    
    public Vector3 RandomSpawnPosition()
    {
        randomX = Random.Range(-xRange, xRange);
        return new Vector3(randomX, 0, spawnZ);
    }

    
    public void SpawnAnimal()
    {
        randomIndex = Random.Range(0, animalPrefabs.Length);
        spawnPosition = RandomSpawnPosition();
        Instantiate(animalPrefabs[randomIndex], spawnPosition,
            animalPrefabs[randomIndex].transform.rotation);
    }
    
}
