using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

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

    public int number1;
    public int number2;

    public Vector3 initialPos = new Vector3(2, 1, 0);
    
    
    
    void Start()
    {
        initialPos = Vector3.zero;
        transform.position = initialPos;
        
        
        Debug.Log(Product(number1, number2));
        
        // HelloWorld();
        //hello = GetHello();
        //Debug.Log(hello);
        
        // Debug.Log(GetHello());

        // myPos = new Vector3(2, 1, 0);
        transform.position = myPos;
        
        //transform.position = Vector3.zero;
        // Debug.Log(transform.position);
        
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
        MovementToDirection(KeyCode.D, Vector3.right);
        MovementToDirection(KeyCode.A, Vector3.left);
        MovementToDirection(KeyCode.W, Vector3.forward);
        MovementToDirection(KeyCode.S, Vector3.back);
        MovementToDirection(KeyCode.E, Vector3.up);
        MovementToDirection(KeyCode.Q, Vector3.down);
        
        Scale(KeyCode.X, Vector3.right);
        Scale(KeyCode.Y, Vector3.up);
        Scale(KeyCode.Z, Vector3.forward);
        
        RotationToDirection(KeyCode.RightArrow, new Vector3(0, 10, 0));
        RotationToDirection(KeyCode.LeftArrow, new Vector3(0, -10, 0));

       
    }

    public void HelloWorld()
    {
        Debug.Log("¡Hola, Mundo!");
    }

    public string GetHello()
    {
        return "¡Hola!"; 
    }

    public void MovementToDirection(KeyCode key, Vector3 direction)
    {
        if (Input.GetKeyDown(key))
        {
            transform.position += direction;
        }
    }

    public void Scale(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale += axis;
        }
    }

    public void RotationToDirection(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.rotation *= Quaternion.Euler(axis);
        }
    }

    public int Product(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log($"{num1} * {num2} = {result}");
        return result;
    }






}
