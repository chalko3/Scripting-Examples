using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    public int score = 0;
    public string playerName = "John Doe";
    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        IncreaseScore();
        PrintPlayerName();
        DecreaseHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void IncreaseScore()
    {
        score += 10;
    }

    private void PrintPlayerName()
    {
        Debug.Log(playerName);
    }

    private void DecreaseHealth()
    {
        health -= 20;
    }
}
