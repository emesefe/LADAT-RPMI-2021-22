using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
    public bool gameOver;

    public ParticleSystem explosionParticleSystem;
    public ParticleSystem dirtParticleSystem;

    public AudioClip jumpClip;
    public AudioClip crashClip;
    
    private Rigidbody playerRigidbody;
    private Animator playerAnimator;
    private AudioSource playerAudioSource;
    private AudioSource cameraAudioSource;
    
    [SerializeField] private float jumpForce = 400f;
    public float gravityModifier = 1;
    private bool isOnTheGround = true; // Con esta variable evitaremos el doble salto

    private int lives = 3; // Total de vidas

    void Start()
    {
        // Inicializamos las variables
        gameOver = false;
        
        // Accedemos a las componentes que necesitamos
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAudioSource = GetComponent<AudioSource>();
        cameraAudioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        
        // Modificamos la gravedad
        // * Con un valor igual a 1, la gravedad no se modifica
        // * Con un valor mayor a 1, la gravedad es mayor (cuesta más despegarse del suelo)
        // * Con un valor menor a 1, la gravedad es menor (flotamos más)
        // * Con un valor igual a 0, no hay gravedad
        // * Con un valor negativo, la gravedad se invierte
        Physics.gravity *= gravityModifier;

        lives = 3;
    }
    
    void Update()
    {
        // Saltamos cuando estamos en el suelo y pulsamos la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround && !gameOver)
        {
            // Aplicamos fuerza vertical con modo impulso
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
            // Indicamos que hemos dejado de tocar el suelo
            isOnTheGround = false;
            
            // Transicionamos a la animación de salto
            playerAnimator.SetTrigger("Jump_trig");
            
            // Paramos el sistema de partículas de la tierra
            dirtParticleSystem.Stop();
            
            // SFX de salto
            playerAudioSource.PlayOneShot(jumpClip, 1);
        }
        
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (!gameOver) // gameOver true false
                       // !gameOver false true
        {
            // Si colisionamos con el suelo, entonces tocamos el suelo
            if (otherCollider.gameObject.CompareTag("Ground"))
            {
                isOnTheGround = true;

                // Activamos el sistema de partículas de la tierra
                dirtParticleSystem.Play();
            }

            // Si colisionamos con un obstáculo, entonces morimos
            if (otherCollider.gameObject.CompareTag("Obstacle"))
            {
                Destroy(otherCollider.gameObject);
                
                lives--;
                if (lives <= 0)
                {
                    GameOver();
                }
                else
                {
                    playerAnimator.SetTrigger("Crash_trig");
                }


            }
        }
    }

    private void GameOver()
    {
        // Indicamos que hemos muerto
        gameOver = true;

        // Desactivamos el sistema de partículas de la tierra
        dirtParticleSystem.Stop();

        // Ejecutamos el sistema de partículas de explosión
        Vector3 offset = new Vector3(0, 1.5f, 0);
        Instantiate(explosionParticleSystem,
            transform.position + offset,
            explosionParticleSystem.transform.rotation);
                
        /*
        ParticleSystem explosionEscena = Instantiate(explosionParticleSystem,
            transform.position + new Vector3(0, 1.5f, 0),
            explosionParticleSystem.transform.rotation);
        explosionEscena.Play();
        */
                
        // Transicionamos a la animación de muerte, de forma aleatoria
        int randomDeath = Random.Range(1, 3);
        playerAnimator.SetBool("Death_b", true);
        playerAnimator.SetInteger("DeathType_int", randomDeath);
                
        // Reproducir el SFX de la explosión
        playerAudioSource.PlayOneShot(crashClip, 1);
                
        // Bajar el volumen de la música de fondo
        cameraAudioSource.volume = 0.01f;
    }
}
