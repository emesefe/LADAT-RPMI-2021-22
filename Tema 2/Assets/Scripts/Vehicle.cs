using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Variable que guarda el sonido del vehiculo 
    [SerializeField] private string sound = "¡Brum, brum!";

    private int x = 3;
    private int y = 6;

    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        x /= y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
