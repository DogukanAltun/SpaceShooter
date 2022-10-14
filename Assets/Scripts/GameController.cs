using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject Hazard;
    public float SpawnWait;
    float StartWait = 5;
    float Wait = 7;
    public Text ScoreText;
    public Text GameOverText;
    public Text RestartText;
    public Text QuitText;
    private bool gameOver;
    private bool restart;
    public int Score;


    void Update()
    {
        if (restart == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
                Debug.Log("Oyun Kapandý!");
            }
        }
    }
    IEnumerator SpawnValues()
    {
        yield return new WaitForSeconds(StartWait);
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(3, -3), -3, 3);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(Hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(SpawnWait);
            }
            yield return new WaitForSeconds(Wait);
            if (gameOver == true)
            {
                restart = true;
                RestartText.text = "Press 'R' to Restart";
                QuitText.text = "Press 'Q' to Quit";
                break;
              
            }
        }
    }
    public void UpdateScore()
    {
       Score += 10;
        ScoreText.text = "Score: " + Score;
    }

    public void GameOver()
    {
        gameOver = true;
        GameOverText.text = "Game Over Score:"+ Score;
    }

   
    void Start()
    {
        GameOverText.text = "";
        RestartText.text = "";
        gameOver = false;
        restart = false;
        StartCoroutine(SpawnValues());

    }
}
