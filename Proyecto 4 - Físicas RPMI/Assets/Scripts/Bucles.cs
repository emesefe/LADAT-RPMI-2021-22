using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject[] enemyPrefabs;
    public Vector3[] positions;

    public int initialNum = 10;
    
    void Start()
    {
        // FOR
        /*for (int i = 0; i < positions.Length; i++)
        {
            Instantiate(enemyPrefab, positions[i], 
                enemyPrefab.transform.rotation);
        }*/
        
        /*for (int i = 0; i < positions.Length; i++)
        {
            Instantiate(enemyPrefabs[i], positions[i], 
                enemyPrefabs[i].transform.rotation);
        }*/


        /*for (int i = 10; i >= 0; i = i - 1)
        {
            Debug.Log(i);
        }*/
        
        
        
        // FOREACH
        /*foreach (Vector3 pos in positions)
        {
            Instantiate(enemyPrefab, pos, 
                enemyPrefab.transform.rotation);
        }*/
        
        
        // WHILE
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(FadeCorroutine());
        }
    }

    public void Fade()
    {
        float alphaValue = 0;
        MeshRenderer cubeMeshRenderer = GetComponent<MeshRenderer>();
        Color color = cubeMeshRenderer.material.color;
        
        while (alphaValue <= 1)
        {
            color.a = alphaValue;
            Debug.Log(alphaValue);
            cubeMeshRenderer.material.color = color;
            alphaValue += 0.1f;
        }
    }
    
    public IEnumerator FadeCorroutine()
    {
        float alphaValue = 0;
        MeshRenderer cubeMeshRenderer = GetComponent<MeshRenderer>();
        Color color = cubeMeshRenderer.material.color;
        
        while (alphaValue <= 1)
        {
            color.a = alphaValue;
            Debug.Log(color);
            cubeMeshRenderer.material.color = color;
            alphaValue += 0.1f;
            yield return new WaitForSeconds(1);
        }
    }
}
