using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertDirection : MonoBehaviour
{
    private float xLim = 8;
    private float yLim = 4;
    private Move moveScript = null;
    
    
    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xLim || transform.position.x > xLim ||
            transform.position.y < -yLim || transform.position.y > yLim)
        {
            moveScript.direction *= -1;
        }
    }
}
