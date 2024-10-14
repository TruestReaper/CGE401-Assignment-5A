/*
* Name: John Chirayil
* File: ScoreManager.cs
* CGE401 - Assignment 5A 
* Description: Manages the score system UI.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public PlayerPlatformerController playerControllerScript;
    public bool won = false;
    public static bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPlatformerController>();
        }

        scoreText.text = "Score: 0";
        gameOver = false; // Ensure the game starts without gameOver being true
    }

    // Update is called once per frame
    void Update()
    {
        // Display score until game is over
        if (!gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        // Loss Condition: Hit the obstacle
        if (gameOver && !won)
        {
            scoreText.text = "You Lose!\nPress R to Try Again!";
        }

        // Win Condition: 10 points
        if (score >= 2)
        {
            gameOver = true;
            won = true;

            // Stop player from running
            scoreText.text = "You Win!\nPress R to Try Again!";
        }

        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
