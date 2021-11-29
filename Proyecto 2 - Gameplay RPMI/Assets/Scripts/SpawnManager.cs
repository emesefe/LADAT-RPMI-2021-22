using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public Vector3 spawnPosition = new Vector3(0, 0, 25);
    
    private float xRange = 15f;
    

    void Start()
    {
        InvokeRepeating("SpawnAnimal", 2, 1.5f);
    }
    
    public Vector3 RandomSpawnPosition()
    {
        float randomX = Random.Range(-xRange, xRange);
        return new Vector3(randomX, 0, 25);
    }

    
    public void SpawnAnimal()
    {
        int randomIndex = Random.Range(0, animalPrefabs.Length);
        spawnPosition = RandomSpawnPosition();
        Instantiate(animalPrefabs[randomIndex], spawnPosition,
            animalPrefabs[randomIndex].transform.rotation);
    }
    
}
