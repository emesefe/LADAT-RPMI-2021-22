using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Para que la repetición del fondo funcione, se requiere la componente MoveLeft
[RequireComponent(typeof(MoveLeft))]
public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    public float repeatWidth;
    
    void Start()
    {
        startPosition = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2f;
    }
    
    void Update()
    {
        // Si nos hemos desplazado la mitad de la anchura del fondo hacia la izquierda,
        // entonces volvemos a la posición inicial para crear el efecto de que el fondo
        // es infinito
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
        
    }
}
