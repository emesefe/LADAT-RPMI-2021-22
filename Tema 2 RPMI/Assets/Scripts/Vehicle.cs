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
    // Variable que indica si el vehículo está en marcha
    [SerializeField] private bool isOn = true;
    // Variable que indica si el vehículo tiene sirena
    [SerializeField] private bool hasSiren;
    
    // Start is called before the first frame update
    void Start()
    {
        /*
         Debug.Log($"{name} tiene {numberWheels} ruedas y hace {sound}");
         */
        if (isOn == true)
        {
            Debug.Log(sound);
        }else if (hasSiren == true)
        {
            Debug.Log($"{name} hará {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log($"{name} no está en marcha");
        }
    }

// Update is called once per frame
    void Update()
    {
    
    }
}
