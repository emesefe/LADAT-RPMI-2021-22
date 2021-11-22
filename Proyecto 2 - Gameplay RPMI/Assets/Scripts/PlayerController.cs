using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10f;
    public float xRange = 16f;

    public GameObject projectilePrefab;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        // Límite de pantalla derecho
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,
                transform.position.z);
        }
        
        // Límite de pantalla izquierdo
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,
                transform.position.z);
        }
        
        // Disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position,
                projectilePrefab.transform.rotation);
        }
    }
}
