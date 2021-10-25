using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    private float playerSpeed = 5.25f;
    public string playerName = "Maria";
    [SerializeField] private bool gameOver;
    
    public float a = 5f;
    public float b = 2f;
    
    public int playerAge = 35;
    public int x = 5;
    public int y = 2;
    
    
    public bool isRaining;
    public bool isCold;
    */

    public Vector3 myPos = new Vector3(2, 1, 0);
    public string hello;
    
    
    
    void Start()
    {
        HelloWorld();
        
        
        
        //hello = GetHello();
        //Debug.Log(hello);
        
        Debug.Log(GetHello());

        // myPos = new Vector3(2, 1, 0);
        transform.position = myPos;
        
        //transform.position = Vector3.zero;
        Debug.Log(transform.position);
        
        /*
        if (isRaining == true)
        {
            if (isCold == true)
            {
                Debug.Log("Lleva paraguas y sudadera");
            }
            else
            {
                Debug.Log("Lleva paraguas");
            }
        }
        else 
        {
            if (isCold == true)
            {
                Debug.Log("Lleva una sudadera");
            }
            else
            {
                Debug.Log("Disfruta del día.");
            }
        }
        
        
        if (x == 2 || y <= 5)
        {
            Debug.Log("Verdadero");
        }
        else
        {
            Debug.Log("Falso");
        }
        
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log(string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(string.Format("Division: {0} / {1} = {2}", x, y, x / y));
        

        if (playerAge >= 18)
        {
            Debug.Log("Eres mayor de edad");
        }else if (playerAge >= 13)
        {
            Debug.Log("Eres adolescente");
        }
        else if  (playerAge >= 4)
        {
            Debug.Log("Eres un niño");
        }
        else
        {
            Debug.Log("Eres un bebe");
        }
        */



    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform.position);
        
        // Muevo para la derecha si pulso tecla derecha 
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left;
            // transform.position += -1 * Vector3.right;
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position += Vector3.up;
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position += Vector3.down;
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward;
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 10, 0);
        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(0, -10, 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localScale += Vector3.right;
        }
    }

    public void HelloWorld()
    {
        Debug.Log("¡Hola, Mundo!");
    }

    public string GetHello()
    {
        return "¡Hola!"; 
    }
    
    
    
    
    
    
    
}
