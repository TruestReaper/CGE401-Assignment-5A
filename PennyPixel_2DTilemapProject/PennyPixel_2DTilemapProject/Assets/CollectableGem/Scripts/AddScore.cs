/*
* Name: John Chirayil
* File: AddScore.cs
* CGE401 - Assignment 5A 
* Description: Increments the score when player
* collides with gem.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private ScoreManager scoreManager;
    private bool triggered = false;

    // Start is called before the first frame update
    private void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            scoreManager.score++;
        }
    }
}
