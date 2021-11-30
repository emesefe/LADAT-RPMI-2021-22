using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f; 
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
