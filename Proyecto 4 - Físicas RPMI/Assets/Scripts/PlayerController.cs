using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    //public GameObject powerUpIndicator;
    public GameObject[] powerUpIndicators;
    //public GameObject[] powerUpIndicatorsPrefab;
    
    private Rigidbody playerRigidbody;
    [SerializeField] private float speed = 10f;
    private GameObject focalPoint;

    private bool hasPowerUp;
    private float powerUpForce = 15f;
    
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }
    
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        playerRigidbody.AddForce(focalPoint.transform.forward * speed * verticalInput);
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Powerup"))
        {
            hasPowerUp = true;
            StartCoroutine(PowerUpCountDown());
            Destroy(otherCollider.gameObject);
        }
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (hasPowerUp && otherCollider.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRigidbody = otherCollider.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (otherCollider.gameObject.transform.position -
                                      transform.position).normalized;
            enemyRigidbody.AddForce(awayFromPlayer * powerUpForce, ForceMode.Impulse);
        }
    }

    private IEnumerator PowerUpCountDown()
    {
        for (int i = 0; i < powerUpIndicators.Length; i++)
        {
            // Game Object en Escena
            powerUpIndicators[i].SetActive(true);
            yield return new WaitForSeconds(2);
            powerUpIndicators[i].SetActive(false);
        }
        hasPowerUp = false;
    }
}
