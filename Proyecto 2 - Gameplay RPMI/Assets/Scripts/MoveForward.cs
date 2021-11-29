using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Movimiento hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
