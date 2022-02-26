using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int points;
    public ParticleSystem explosionParticle;
    
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
        if (!gameManagerScript.isGameOver)
        {
            gameManagerScript.UpdateScore(points);
            Instantiate(explosionParticle, transform.position, 
                explosionParticle.transform.rotation);

            // Destruimos el target si hacemos click sobre éste
            Destroy(gameObject);

            // Si le damos a un target malo (calavera), Game Over
            if (gameObject.CompareTag("Bad"))
            {
                gameManagerScript.GameOver();
            }
        }
    }

    private void OnDestroy()
    {
        // Cuando se destruye el target, comunicamos a Game Manager que la posición queda libre
        gameManagerScript.targetPositions.Remove(transform.position);
    }
}
