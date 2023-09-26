using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    private bool player1Finished = false;
    private bool player2Finished = false;

    void Update()
    {
        if (player1Finished && player2Finished)
        {
            LoadNextLevel();
        }

    }

    private void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        SceneManager.LoadScene(nextSceneIndex);
    }

    public void SetPlayerFinished(string playerTag)
    {
        if (playerTag == "Player1")
        {
            player1Finished = true;
        }
        else if (playerTag == "Player2")
        {
            player2Finished = true;
        }
    }
}
