using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour
{
    [SerializeField] Text player1ScoreText;
    [SerializeField] Text player2ScoreText;

    player player1;
    

    void Start()
    {

        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
    }

    void Update()
    {

        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        player1ScoreText.text = "Player 1 Score: " + player1.score.ToString();
        player2ScoreText.text = "Player 2 Score: " + player2.score.ToString();
    }
    public class Player
    {
        public int score = 0;
    }
}
