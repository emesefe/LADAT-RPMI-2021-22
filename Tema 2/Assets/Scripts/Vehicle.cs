using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Variable que guarda el sonido del vehiculo
    [SerializeField] private string sound = "Brum, brum";
    // Variable que guarda el nombre del vehiculo
    [SerializeField] private string name;
    // Variable que guarda el num de ruedas
    [SerializeField] private int numberWheels = 4;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"{name} tiene {numberWheels} ruedas y hace {sound}");
    }

// Update is called once per frame
    void Update()
    {
    
    }
}
