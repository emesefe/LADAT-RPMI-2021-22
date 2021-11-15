using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 15.0f;
    private float horizontalInput;
    private float verticalInput;
    
    void Update()
    {
        // Tomamos eje horizontal del Input Manager
        horizontalInput = Input.GetAxis("Horizontal");
        // Tomamos eje vertical del Input Manager
        verticalInput = Input.GetAxis("Vertical");
        
        // Movimiento hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        
        // Movimiento lateral
        // transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        
        // Rotación
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        
    }
}
