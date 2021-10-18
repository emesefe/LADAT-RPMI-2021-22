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
    

    public int x = 5;
    public int y = 2;
    
    public float a = 5f;
    public float b = 2f;

    public bool isRaining = false;
    */
    
    public int playerAge = 35;
    
    void Start()
    {
        /*
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log(string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(string.Format("Division: {0} / {1} = {2}", x, y, x / y));
        
        
        if (isRaining == true)
        {
            Debug.Log("Lleva paraguas");
        }
        else 
        {
            Debug.Log("No llueve. No lleves paraguas.");
        }
        

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
        Debug.Log(transform.position);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
