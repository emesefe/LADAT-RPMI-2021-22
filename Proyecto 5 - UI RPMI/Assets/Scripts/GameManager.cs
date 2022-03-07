using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] targetPrefabs;
    public bool isGameOver;
    public List<Vector3> targetPositions; // Guarda las posiciones ocupadas

    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    public GameObject mainMenuPanel;

    // Coordenadas del cuadrado inferior izquierdo
    private float minX = -3.75f;
    private float minY = -3.75f;
    // Distancia entre los centros de los cuadrados (horizontal y vertical)
    private float distanceBetweenSquares = 2.5f;

    public float spawnRate = 2f;
    private Vector3 randomPos;

    private int score;
    
    void Start()
    {
        mainMenuPanel.SetActive(true);
    }

    private Vector3 RandomSpawnPosition()
    {
        // Función que calcula una posición aleatoria en los centros de los 16 cuadrados
        
        int saltosX = Random.Range(0, 4);
        int saltosY = Random.Range(0, 4);

        // Partimos desde el cuadrado inferior izquierdo
        // Calculamos el desplazamiento hacia la derecha
        float spawnPosX = minX + saltosX * distanceBetweenSquares;
        // Calculamos el desplazamiento hacia arriba
        float spawnPosY = minY + saltosY * distanceBetweenSquares;
        
        return new Vector3(spawnPosX, spawnPosY, 0);
    }

    private IEnumerator SpawnRandomTarget()
    {
        while (!isGameOver)
        {
            // Esperamos spawnRate segundos
            yield return new WaitForSeconds(spawnRate);
            
            // Elegimos de forma aleatoria el target que va a aparecer
            int randomIndex = Random.Range(0, targetPrefabs.Length);
            
            // Calculamos la posición aleatoria
            randomPos = RandomSpawnPosition();
            // Comprobamos que no está ocupada (solo hay un total de 16 disponibles)
            while (targetPositions.Contains(randomPos))
            {
                randomPos = RandomSpawnPosition();
            }

            // Instanciamos el objeto
            Instantiate(targetPrefabs[randomIndex], randomPos,
                targetPrefabs[randomIndex].transform.rotation);
            // Añadimos su posición a la lista de posiciones ocupadas
            targetPositions.Add(randomPos);
        }
    }

    public void UpdateScore(int pointToAdd)
    {
        score += pointToAdd;
        scoreText.text = $"Score: {score}";
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame(int difficulty)
    {
        mainMenuPanel.SetActive(false);
        
        isGameOver = false;
        gameOverPanel.SetActive(false);
        
        score = 0;
        UpdateScore(0);

        spawnRate = 2f;
        spawnRate /= difficulty;
        StartCoroutine(SpawnRandomTarget());
    }
}
