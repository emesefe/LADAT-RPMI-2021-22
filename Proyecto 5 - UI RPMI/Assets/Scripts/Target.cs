using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float lifeTime = 2f;

    private GameManager gameManagerScript;
    void Start()
    {
        // Autodestrucción tras 2 segundos
        Destroy(gameObject, lifeTime);
        gameManagerScript = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);

        if (gameObject.CompareTag("Bad"))
        {
            gameManagerScript.isGameOver = true;
        }
    }

    private void OnDestroy()
    {
        gameManagerScript.targetPositions.Remove(transform.position);
    }
}
