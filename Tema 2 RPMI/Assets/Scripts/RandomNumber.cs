using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour
{

    private int randNum;
    private int myNum;
    private int counter; // Contador de intentos
    
    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(0, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            myNum = int.Parse(GetComponent<InputField>().text);
            CompareToRandomNumber(myNum);
            counter++; // A la variable counter le sumamos 1
        }

    }

    public void CompareToRandomNumber(int userNum)
    {
        if (userNum > randNum)
        {
            Debug.Log("El número que yo había pensado es más pequeño");
        }

        if (userNum < randNum)
        {
            Debug.Log("El número que yo había pensado es más grande");
        }

        if (userNum == randNum)
        {
            Debug.Log($"¡HAS ACERTADO! El número que había pensado era el {randNum}");
            Debug.Log($"Has utilizado {counter} intentos");
        }
    }
}
