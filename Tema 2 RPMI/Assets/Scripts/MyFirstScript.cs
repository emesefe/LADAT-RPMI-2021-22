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
    */
    
    public bool isRaining;
    public bool isCold;
    
    
    
    
    void Start()
    {
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
        
        /*
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
        
    }
}
