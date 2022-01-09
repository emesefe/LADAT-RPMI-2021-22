using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public float startDelay = 2f;
    public float repeatRate = 2f;
    
    void Start()
    {
        // Spawneamos obstáculos cada cierto intervalo de tiempo
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    public void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
