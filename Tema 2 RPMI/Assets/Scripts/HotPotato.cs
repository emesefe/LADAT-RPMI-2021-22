using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class HotPotato : MonoBehaviour
{
    private int counter;
    public Color colorMat;
    
    
    // Start is called before the first frame update
    void Start()
    {
        counter = Random.Range(3, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //colorMat = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        colorMat = new Color(0, 0, 0);
        GetComponent<MeshRenderer>().material.color = colorMat;
        transform.localScale += 2 * Vector3.one;
        counter--; // A counter le restamos una unidad

        if (counter <= 0)
        {
            Destroy(gameObject);
        }
    }
}
