using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
    public bool gameOver;
    
    private Rigidbody playerRigidbody;
    private Animator playerAnimator;
    [SerializeField] private float jumpForce = 400f;
    public float gravityModifier = 1;
    private bool isOnTheGround = true; // Con esta variable evitaremos el doble salto

    void Start()
    {
        gameOver = false;
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        // Modificamos la gravedad
        // * Con un valor igual a 1, la gravedad no se modifica
        // * Con un valor mayor a 1, la gravedad es mayor (cuesta más despegarse del suelo)
        // * Con un valor menor a 1, la gravedad es menor (flotamos más)
        // * Con un valor igual a 0, no hay gravedad
        // * Con un valor negativo, la gravedad se invierte
        Physics.gravity *= gravityModifier; 
    }
    
    void Update()
    {
        // Saltamos cuando estamos en el suelo y pulsamos la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround)
        {
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnTheGround = false;
            playerAnimator.SetTrigger("Jump_trig");
        }
        
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Ground"))
        {
            isOnTheGround = true;
        }

        if (otherCollider.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            int randomDeath = Random.Range(1, 3);
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", randomDeath);
        }
        
        
    }
}
